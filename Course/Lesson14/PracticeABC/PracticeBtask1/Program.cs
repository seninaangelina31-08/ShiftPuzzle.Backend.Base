using System;
using System.Net;
using System.IO;
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
        string randomUserJson = GetRequest("https://randomuser.me/api/");
        RandomUserApiResponse randomUserResponse = JsonSerializer.Deserialize<RandomUserApiResponse>(randomUserJson);

        string genderizeUrl = $"https://api.genderize.io/?name={randomUserResponse.results[0].name.first}";
        string genderizeJson = GetRequest(genderizeUrl);
        GenderizeApiResponse genderizeResponse = JsonSerializer.Deserialize<GenderizeApiResponse>(genderizeJson);

        if (randomUserResponse.results[0].gender.ToLower() == genderizeResponse.gender.ToLower())
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("Нет");
        }
    }

    public class RandomUserApiResponse
    {
        public Result[] results { get; set; }
    }

    public class Result
    {
        public Name name { get; set; }
        public string gender { get; set; }
    }

    public class Name
    {
        public string first { get; set; }
    }

    public class GenderizeApiResponse
    {
        public string gender { get; set; }
    }
}
