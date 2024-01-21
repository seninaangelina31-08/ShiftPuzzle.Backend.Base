namespace PracticeA4;
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
        string URL = ""; 
        string json = GetRequest(URL); 
        
         response = JsonSerializer.Deserialize<>(json);
        
        
        Console.Write();
    }
}