namespace PracticeC;
using System.Net;
using System.IO;
using System;
using System.Text.Json;


class Place
{
    public string latitude {get; set;}
    public string longitude {get; set;}
}
class Pochta
{
    public List<Place> places {get; set;}
}
class IP
{
    public string ip {get; set;}
}
class Geo
{
    public string country {get; set;}
    public string postal {get; set;}
}
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
        string URL = "https://api.ipify.org/?format=json"; 
        string json = GetRequest(URL); 

        IP my_ip = JsonSerializer.Deserialize<IP>(json);

        string URL2 = $"https://ipinfo.io/{my_ip.ip}/geo";
        string json2 = GetRequest(URL2);

        Geo Post = JsonSerializer.Deserialize<Geo>(json2);

        string URL3 = $"https://api.zippopotam.us/{Post.country}/{Post.postal}";
        string json3 = GetRequest(URL3);

        Pochta pocht = JsonSerializer.Deserialize<Pochta>(json3);

        Console.WriteLine($"Широта: {pocht.places[0].latitude} \nДолгота: {pocht.places[0].longitude}");
    }
}
