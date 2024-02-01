using System;
using System.Net;
using System.IO;
using System.Text.Json;

class Program
{
    class Top
    {
        public string name { get; set; }
        public string[] domains { get; set; }
        public string country { get; set; }
        public string state_province { get; set; }
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
        string TopURL = "http://universities.hipolabs.com/search?country=Kazakhstan";
        string jsonFromTopURL = GetRequest(TopURL);
        Top[] tops = JsonSerializer.Deserialize<Top[]>(jsonFromTopURL);

        foreach(Top top in tops.Take(3))
        {
            Console.WriteLine("Name: " + top.name);
            
        }
    }
}