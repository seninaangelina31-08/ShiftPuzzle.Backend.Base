namespace Homework;
using System;
using System.Text;
using System.Collections.Generic;
using System.Text.Json;
using System.Net;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string FreeAPIsURL = "https://api.publicapis.org/entries";
        string JsonFromFile1 = GetRequest(FreeAPIsURL);

        APIs ListOfApi = JsonSerializer.Deserialize<APIs>(JsonFromFile1);

        // Запись FREE_API.txt
        // StreamWriter stream1 = new StreamWriter("FREE_API.txt", true);

        // stream1.Write($"Бесплатные API\n");
        // foreach(Entry entry in ListOfApi.entries)
        // {
        //     stream1.Write($"{entry.Link}\n");
        // }


        // Запись FREE_API_WITH_DESCRIPTION.txt
        // StreamWriter stream2 = new StreamWriter("FREE_API_WITH_DESCRIPTION.txt", true);

        // stream2.WriteLine($"Бесплатные API");
        // foreach(Entry entry in ListOfApi.entries)
        // {
        //     stream2.WriteLine($"Ссылка: {entry.Link}");
        //     stream2.WriteLine($"Описание: {entry.Description}");
        //     stream2.Write($"Авторизация: ");
        //     if (entry.Auth != "")
        //     {
        //         stream2.WriteLine($"{entry.Auth}\n");
        //     }
        //     else
        //     {
        //         stream2.WriteLine($"Не нужна\n");
        //     }
        // }
    }
    public static string GetRequest(string url)
    {
        WebRequest request = WebRequest.Create(url);
        WebResponse response = request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader streamReader = new StreamReader(dataStream);
        string jsonResponse = streamReader.ReadToEnd();

        response.Close();
        streamReader.Close();

        return jsonResponse;
    }
}
