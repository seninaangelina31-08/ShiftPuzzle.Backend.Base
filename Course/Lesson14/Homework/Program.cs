using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var response = await client.GetAsync("https://api.publicapis.org/entries");
            var json = await response.Content.ReadAsStringAsync();

            var doc = JsonDocument.Parse(json);
            var entries = doc.RootElement.GetProperty("entries").EnumerateArray();

            foreach (var entry in entries)
            {
                if (entry.TryGetProperty("Auth", out _))
                {
                    string link = entry.GetProperty("Link").GetString();
                    string description = entry.TryGetProperty("Description", out var desc) ? desc.GetString() : "No description";
                    string auth = "Нет";

                    File.AppendAllText("FREE_API.txt", $"ССЫЛКА: {link}\nОПИСАНИЕ: {description}\nАВТОРИЗАЦИЯ: {auth}\n\n");
                }
            }
        }
    }
}