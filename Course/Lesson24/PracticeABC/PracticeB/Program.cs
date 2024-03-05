using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Задача 1: Загрузка файла из сети по URL и сохранение его локально
        string url = "https://i.ytimg.com/vi/dK8BAz-GA6M/maxresdefault.jpg";
        string localFilePath = "clown.jpg";
        await DownloadFileAsync(url, localFilePath);

        // Задача 2: Асинхронное чтение и запись файлов
        string filePath = "input.txt";
        await WriteToFileAsync(filePath, "Привет, мир!");
        await ReadFromFileAsync(filePath);

        // Задача 3: Выполнение параллельных HTTP-запросов к нескольким серверам
        List<string> urls = new List<string> { "http://google.com", "http://yandex.ru", "http://yahoo.com" };
        await FetchDataAsync(urls); 
 
    }

    static async Task DownloadFileAsync(string url, string filePath)
    {
        using (var httpClient = new HttpClient())
        {
            //отправка запроса на сервер
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode) //проверка успешности запроса
            {
                using (var fileStream = new FileStream(filePath, FileMode.Create)) 
                {
                    await response.Content.CopyToAsync(fileStream); // сохранение файла  c CopyToAsync(fileStream)
                }
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
            await writer.WriteAsync(content); // запись в файл асинхронно
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
            var tasks = new List<Task>();
            foreach (var url in urls)
            {
                // Выполняем HTTP-запрос асинхронно и добавляем задачу в список
                tasks.Add(Task.Run(async () =>
                {
                    try
                    {
                        HttpResponseMessage response = await httpClient.GetAsync(url);
                        response.EnsureSuccessStatusCode();
                        string responseBody = await response.Content.ReadAsStringAsync();
                        Console.WriteLine($"{url} - Запрос выполнен");
                    }
                    catch (HttpRequestException ex)
                    {
                        Console.WriteLine($"Ошибка при выборе URL-адреса '{url}': {ex.Message}");
                    }
                }));
            }

            // Дожидаемся выполнения всех асинхронных задач
            await Task.WhenAll(tasks);
        }
    }

     
}
