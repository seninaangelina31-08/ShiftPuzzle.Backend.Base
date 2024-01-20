namespace PracticeC;
using System;
using System.IO;
using System.Text.Json;
using System.Net;
class Program
{
    static void Main(string[] args)
    {
        string ipURL = "https://api.ipify.org?format=json";
        Ip IPjson = JsonSerializer.Deserialize<Ip>(GetRequest(ipURL));

        string MyIp = IPjson.ip;
        Console.WriteLine(GetPostCoord(MyIp));
    }

    public static string GetRequest(string url)
    {
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader streamReader = new StreamReader(dataStream);
        string jsonResponse = streamReader.ReadToEnd();

        response.Close();
        streamReader.Close();
        return jsonResponse;
    }

    public static string GetPostCoord(string ip)
    {
        string geoDataURL = $"https://ipinfo.io/{ip}/geo";
        GeoData geoData = JsonSerializer.Deserialize<GeoData>(GetRequest(geoDataURL));

        string abbrevCountry = geoData.country;
        string MyPostal = geoData.postal;


        string geoLocURL = $"https://api.zippopotam.us/{abbrevCountry}/{MyPostal}";
        GeoLoc geoLoc = JsonSerializer.Deserialize<GeoLoc>(GetRequest(geoLocURL));

        string PostLatitude = geoLoc.places[0].latitude;
        string PostLongitude = geoLoc.places[0].longitude;

        string Coords = $"Широта: {PostLatitude}\nДолгота: {PostLongitude}";
        return Coords;
    }
}
