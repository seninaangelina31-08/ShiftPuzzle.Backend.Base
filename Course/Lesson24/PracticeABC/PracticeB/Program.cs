﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    string read;
    static async Task Main(string[] args)
    {
        // Задача 1: Загрузка файла из сети по URL и сохранение его локально
        string url = "https://emojiisland.com/cdn/shop/products/Emoji_Icon_-_Clown_emoji_large.png";
        string localFilePath = "clown.png";
        await DownloadFileAsync(url, localFilePath);

        // Задача 2: Асинхронное чтение и запись файлов
        string filePath = "input.txt";
        await WriteToFileAsync(filePath, "Привет, мир!");
        Console.WriteLine(await ReadFromFileAsync(filePath));

        // Задача 3: Выполнение параллельных HTTP-запросов к нескольким серверам
        List<string> urls = new List<string> { "http://google.com", "http://yandex.ru", "http://yahoo.com" };
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

    static async Task<string> ReadFromFileAsync(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            return await reader.ReadToEndAsync();
        }
    }

    static async Task FetchDataAsync(List<string> urls)
    {
        using (var httpClient = new HttpClient())
        {
            foreach (var url in urls)
            {
                await httpClient.GetAsync(url);
                Console.WriteLine($"Запрос к {url} выполнен");
            }
        }
    }

     
}