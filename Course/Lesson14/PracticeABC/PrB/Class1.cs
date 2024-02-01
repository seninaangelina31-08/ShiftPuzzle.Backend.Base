namespace PrB;

using System;
using System.Net;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        string randomUserApiUrl = "https://randomuser.me/api/";
        WebClient randomUserClient = new WebClient();
        string randomUserResponse = randomUserClient.DownloadString(randomUserApiUrl);

        string gender = "";
        using (JsonDocument document = JsonDocument.Parse(randomUserResponse))
        {
            JsonElement root = document.RootElement;
            gender = root.GetProperty("results")[0].GetProperty("gender").GetString();
        }

        string genderizeApiUrl = "https://api.genderize.io/?name=" + gender;
        WebClient genderizeClient = new WebClient();
        string genderizeResponse = genderizeClient.DownloadString(genderizeApiUrl);

        string prediction = "";
        using (JsonDocument document = JsonDocument.Parse(genderizeResponse))
        {
            JsonElement root = document.RootElement;
            prediction = root.GetProperty("gender").GetString();
        }

        if (string.Equals(gender, prediction, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Да");
        }
        else
        {
            Console.WriteLine("НЕТ");
        }
    }
}
