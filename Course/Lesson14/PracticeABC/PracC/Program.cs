namespace PracB;
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

    public class IP
    {
        public string ip { get; set; }
    }
    public class Post
    {
        public string country { get; set; }
        public string postal { get; set; }
    }

    public class Place
    {
        public string longitude { get; set; }
        public string latitude { get; set; }
    }


    static void Main(string[] args)
    {
        string ipURL = $"https://api.ipify.org?format=json"; 
        string jsonFromIP = GetRequest(ipURL);  
        IP ipObject = JsonSerializer.Deserialize<IP>(jsonFromIP);
        
        Console.WriteLine(ipObject.ip);


        string postURL = $"https://ipinfo.io/{ipObject.ip}/geo"; 
        string jsonFromPost = GetRequest(postURL);
        Post posti = JsonSerializer.Deserialize<Post>(jsonFromPost);

        Console.WriteLine(posti.postal);


        string coorURL = $"https://api.zippopotam.us/ru/{posti.postal}"; 
        string jsonFromCoor = GetRequest(coorURL);
        Place coor = JsonSerializer.Deserialize<Place>(jsonFromCoor);

        Console.WriteLine($"Coordinates: {coor.longitude}, {coor.latitude}");
    }
}