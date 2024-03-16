using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    public static string read_string { get; set; }
    static async Task Main(string[] args)
    {
        // Задача 1: Загрузка файла из сети по URL и сохранение его локально
        string url = "https://famt.ru/wp-content/uploads/2019/05/sonnik-govoryaschiy-kot.jpg";
        string localFilePath = "sonnik-govoryaschiy-kot.jpg";
        await DownloadFileAsync(url, localFilePath);  

        // Задача 2: Асинхронное чтение и запись файлов
        string filePath = "568868257.txt";
        await WriteToFileAsync(filePath, "укуекур");
        await ReadFromFileAsync(filePath);
        Console.WriteLine(read_string);

        // Задача 3: Выполнение параллельных HTTP-запросов к нескольким серверам
        List<string> urls = new List<string> {"http://yandex.ru", "http://google.com"};
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
           await writer.WriteAsync(content) ; // запись в файл асинхронно
        }
        Console.WriteLine("Файл успешно записан.");
    }

    static async Task ReadFromFileAsync(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            read_string = await reader.ReadToEndAsync();
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