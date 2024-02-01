namespace Homework;
using System.Net;
using System.IO;
using System;
using System.Text.Json;

class Links
{
    public string Link { get; set; }
}

class APIs
{
    public List<Links> entries { get; set; }
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
    public static void WriteToFile(List<Links> a)
    {
        string[] str = (a.Select(x => x.Link.Contains("github") ? x.Link : null)).ToArray().Where(e => e != null).ToArray();
        File.WriteAllLines("FREE_API.txt", str);
    }

    static void Main(string[] args)
    {
        string URL = "https://api.publicapis.org/entries";
        string json = GetRequest(URL);

        APIs api = JsonSerializer.Deserialize<APIs>(json);
        WriteToFile(api.entries);
    }
}
