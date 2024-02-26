using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Задача  1: Загрузка файла из сети по URL и сохранение его локально
        string url = "https://www.file.io/eWYt/download/TDikYDqjKkss";
        string filePath = "PracticeB.txt";
        await DownloadFileAsync(url, filePath);

        // Задача  2: Асинхронное чтение и запись файлов
        string content = "Пример содержимого файла";
        await WriteToFileAsync(filePath, content);
        await ReadFromFileAsync(filePath);

        // Задача  3: Выполнение параллельных HTTP-запросов к нескольким серверам
        List<string> urls = new List<string>
        {
            "https://ненаю.com",
            "https://ненаю.com"
        };
        await FetchDataAsync(urls);
    }

    static async Task DownloadFileAsync(string url, string filePath)
    {
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create))   
                {
                    await response.Content.CopyToAsync(fileStream);
                }
                Console.WriteLine("Файл успешно загружен.");
            }
            else
            {
                Console.WriteLine("Ошибка загрузки файла.");
            }
        }
    }

    static async Task WriteToFileAsync(string filePath, string content)
    {
        using (var writer = new StreamWriter(filePath))
        {
            await writer.WriteAsync(content);
        }
        Console.WriteLine("Файл успешно записан.");
    }

    static async Task ReadFromFileAsync(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            string content = await reader.ReadToEndAsync();
            Console.WriteLine(content);
        }
    }

    static async Task FetchDataAsync(List<string> urls)
    {
        using (var httpClient = new HttpClient())
        {
            var tasks = urls.Select(url => httpClient.GetAsync(url)).ToArray();
            var responses = await Task.WhenAll(tasks);
            foreach (var response in responses)
            {
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"URL: {response.RequestMessage.RequestUri}, Content: {content}");
                }
                else
                {
                    Console.WriteLine($"Ошибка при запросе URL: {response.RequestMessage.RequestUri}");
                }
            }
        }
    }
}