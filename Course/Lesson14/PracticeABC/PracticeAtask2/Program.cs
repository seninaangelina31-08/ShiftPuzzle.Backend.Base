namespace PracticeAtask2;

using System;
using System.Net;
using System.IO;
using System.Text.Json;

class Program
{
    class CatFact
{
    public string fact { get; set; }
}
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
        string catURL = "https://catfact.ninja/fact";
        string jsonFromcatURL = GetRequest(catURL);
        CatFact catFact = JsonSerializer.Deserialize<CatFact>(jsonFromcatURL);

        Console.WriteLine(catFact.fact);
    }
}
