namespace PracticeA2;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

class Catfact
{
    public string fact {get; set;}
    public int length {get; set;}
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
        string URL = "https://catfact.ninja/fact"; 
        string json = GetRequest(URL); 
        
        Catfact response = JsonSerializer.Deserialize<Catfact>(json);
        
        
        string catfact = response.fact;
        Console.Write(catfact);
    }
}
