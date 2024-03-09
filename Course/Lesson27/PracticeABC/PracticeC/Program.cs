using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace PracticeABC;

class Program
{
    static async Task Main(string[] args)
    {
        string filepath = "SomeText";
        Task[] tasks = new Task[]
        {
            Task.Run(() => CopyFileAsync(filepath)),
            Task.Run(() => ChangeDataAsync(filepath)),
            Task.Run(() => ReWriteDataAsync(filepath))
        };
        await Task.WhenAll(tasks);
    }
    
    static async Task CopyFileAsync(string filepath)
    {
        string filePathCopy = $"{filepath}Copy.txt";
        string filePath = $"{filepath}.txt";
        using (var writer = new StreamWriter(filePathCopy))
        {
            using (var reader = new StreamReader(filePath))
            {
                string line = await reader.ReadToEndAsync();
                await writer.WriteAsync(line);
            }
        }
    }

    static async Task ChangeDataAsync(string filepath)
    {
        await Task.Delay(3000);
        Console.WriteLine("Данные изменены");
    }

    static async Task ReWriteDataAsync(string filepath)
    {
        await Task.Delay(1500);
        Console.WriteLine("Данные перезаписаны");
    }
}
