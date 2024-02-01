using System;
using System.Net;
using System.IO;
using System.Text.Json;

class Program
{
    class Joke
{
    public string setup { get; set; }
    public string punchline { get; set; }
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
        string jokeURL = "https://official-joke-api.appspot.com/random_joke";
        string jsonFromJokeURL = GetRequest(jokeURL);
        Joke joke = JsonSerializer.Deserialize<Joke>(jsonFromJokeURL);

        Console.WriteLine(joke.setup);
        System.Console.WriteLine(joke.punchline);
        
    }
}
