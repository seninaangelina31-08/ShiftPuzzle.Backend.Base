namespace practicec;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

class Program
{

    public static string GetRequest(string url)
    {
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        Stream dataStream = response.GetResponseStream(); 
        StreamReader streamReader = new StreamReader(dataStream); 
        string jsonResponse = streamReader.ReadToEnd(); 

        streamReader.Close();  
        response.Close();  
        return jsonResponse;  
    }

    static void Main(string[] args)
    {
        string ipURL = "https://api.ipify.org?format=json"; 
        string jsonIP = GetRequest(ipURL);  
        IP firstip = JsonSerializer.Deserialize<IP>(jsonIP);        
        string placeIpURL = $"https://ipinfo.io/{firstip.ip}/geo";
        string jsonPlace = GetRequest(placeIpURL);
        PlaceforIp placefromIp = JsonSerializer.Deserialize<PlaceforIp>(jsonPlace);

        string coordinatesURL = $"https://api.zippopotam.us/{placefromIp.country}/{placefromIp.postal}";
        string jsonCoordinates = GetRequest(coordinatesURL);
        Coordinates coor = JsonSerializer.Deserialize<Coordinates>(jsonCoordinates);
        Console.WriteLine($"Долгота - {coor.places[0].longitude}");
        Console.WriteLine($"Широта - {coor.places[0].latitude}");
    }
}
