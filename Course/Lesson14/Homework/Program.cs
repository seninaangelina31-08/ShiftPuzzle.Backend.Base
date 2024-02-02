using System;
using System.Net.Http;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace Homework
// Тут сразу продвинутый и базовый уровни
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string freeApiUrl = "https://api.publicapis.org/entries";

            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(freeApiUrl);

            string responseBody = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions {PropertyNameCaseInsensitive=true};
            var freeApiList = JsonSerializer.Deserialize<FreeApiList>(responseBody, options);

            using (StreamWriter file = new StreamWriter("FREE_API.txt"))
            {
                foreach (var freeApi in freeApiList.Entries)
                {
                    if (freeApi.Link.Contains("github.com") && freeApi.Auth == "")
                    {
                        await file.WriteLineAsync($"ССЫЛКА: {freeApi.Link}");
                        await file.WriteLineAsync($"ОПИСАНИЕ: {freeApi.Description}");
                        await file.WriteLineAsync("АВТОРИЗАЦИЯ: не нужна (т.к. некоторые сервисы могут требовать авторизацию)");
                        await file.WriteLineAsync("#========================================================================================================================#");
                    }
                }
            }
        }
    }

    public class FreeApiList
    {
        public ApiEntry[] Entries { get; set; }
    }

    public class ApiEntry
    {
        public string Auth { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
    }
}
