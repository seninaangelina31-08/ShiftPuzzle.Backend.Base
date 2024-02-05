namespace Homework;
using System;
using System.IO;
using System.Net;
using System.Text.Json;

class Program
{
    static void Main()
    {
        string apiUrl = "https://api.publicapis.org/entries";
        string apiData = FromApi(apiUrl);

        if (apiData != null)
        {

            ApiResponse response = JsonSerializer.Deserialize<ApiResponse>(apiData);

            if (response != null)
            {

                WritToFile(response, "FREE_API.txt");
                Console.WriteLine("URL-ссылки  записаны в файл.");
            }
        }

        Console.ReadLine();
    }

    static string FromApi(string url)
    {

        using (WebClient client = new WebClient())
        {
            return client.DownloadString(url);
        }
    }

    static void WritToFile(ApiResponse response, string filePath)
    {

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var entry in response.Entries)
                {
                    if (entry.Link.Contains("github.com"))
                    {
                        writer.WriteLine(entry.Link);
                    }
                }
            }
        
        
    }
}

class ApiResponse
{
    public ApiEntry[] Entries { get; set; }
}

class ApiEntry
{
    public string Link { get; set; }
}
