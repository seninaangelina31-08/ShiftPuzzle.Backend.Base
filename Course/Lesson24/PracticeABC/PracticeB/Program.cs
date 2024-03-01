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
       
        
        string url = "https://emojiisland.com/cdn/shop/products/Emoji_Icon_-_Clown_emoji_large.png";
        string localFilePath = "clown.png";
        await DownloadFileAsync(url, localFilePath);
        string filePath = "input.txt";
        await WriteToFileAsync(filePath, "Привет, мир!");
        await ReadFromFileAsync(filePath);
        List<string> urls = new List<string> { "http://google.com", "http://yandex.ru", "http://yahoo.com" };
        await FetchDataAsync(urls);
       
        
 
    }

    static async Task DownloadFileAsync(string url, string filePath)
    {
        using (var httpClient = new HttpClient())
        {
            //отправка запроса на сервер
            var response = await httpClient.GetAsync(url);
            if ( response.IsSuccessStatusCode) //проверка успешности запроса
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
          await writer.WriteAsync(content);
        }
        Console.WriteLine("Файл успешно записан.");
    }

    static async Task ReadFromFileAsync(string filePath)
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
           var tasks = urls.Select(url => httpClient.GetStringAsync(url));
            var results = await Task.WhenAll(tasks);
            return results.ToList();  
        }
    }

     
}
