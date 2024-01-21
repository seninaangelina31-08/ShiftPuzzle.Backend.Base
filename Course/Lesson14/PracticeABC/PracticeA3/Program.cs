namespace PracticeA3;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

class Jokes
{
    public string type {get; set;}
    public string setup {get; set;}
    public string punchline {get; set;}
    public int id {get; set;}
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
        string URL = "https://official-joke-api.appspot.com/random_joke"; 
        string json = GetRequest(URL); 
        
        Jokes response = JsonSerializer.Deserialize<Jokes>(json);
        
        
        string joke = response.setup + "\n" + response.punchline;
        Console.Write(joke);
    }
}
