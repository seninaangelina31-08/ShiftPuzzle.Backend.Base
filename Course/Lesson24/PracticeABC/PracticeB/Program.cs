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
        string url = "https://www.vladtime.ru/uploads/posts/2018-03/1522438548_evropeyskaya-koshka-dikiy-kot.jpg";
        string filePath1 = "cat.jpg";
        DownloadFileAsync(url, filePath1);

        // Задача 2: Асинхронное чтение и запись файлов
        string filePath2 = "writer.txt";
        await WriteToFileAsync(filePath2, "I`m kringer");
        await ReadFromFileAsync(filePath2);
        
        // Задача 3: Выполнение параллельных HTTP-запросов к нескольким серверам

        List<string> urls = new List<string> { "http://google.com", "https://tilda.cc/ru/", "https://edu.dobro.ru/" };
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
            await reader.ReadToEndAsync();
        }
    }

    static async Task FetchDataAsync(List<string> urls)
    {
        using (var httpClient = new HttpClient())
        {
             foreach (var url in urls)
            {
                var response = httpClient.GetAsync(url);
                Console.WriteLine($"Запрос к {url} выполнен");
            }
        }
    }

     
}
