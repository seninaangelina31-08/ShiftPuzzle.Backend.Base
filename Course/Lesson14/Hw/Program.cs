﻿namespace Homework;

using System;
using System.Net.Http;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Получаем список бесплатных API
        string apiUrl = "https://api.publicapis.org/entries";
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(apiUrl);
        string responseBody = await response.Content.ReadAsStringAsync();

        // Десериализуем данные
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var apiList = JsonSerializer.Deserialize<ApiList>(responseBody, options);

        // Записываем URL ссылки на Github API в файл
        using (StreamWriter outputFile = new StreamWriter("FREE_API.txt"))
        {
            foreach (var api in apiList.Entries)
            {
                if (api.Auth == "" && api.Link.Contains("github.com"))
                {
                    await outputFile.WriteLineAsync(api.Link);
                }
            }
        }
    }
}

public class ApiList
{
    public ApiEntry[] Entries { get; set; }
}

public class ApiEntry
{
    public string Auth { get; set; }
    public string Link { get; set; }
}