namespace PracticeABC;
using System;
using System.IO;
class Program
{   
    public static async Task Backup(string filePath, string backupFilePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            using (var writer = new StreamWriter(backupFilePath))
            {
                await writer.WriteAsync(await reader.ReadToEndAsync());
                Console.WriteLine("Резервное копирование выполнено");
            }
        }
    }
    static async Task Main(string[] args)
    {
        Task[] tasks = new Task[]
        {
            Task.Run(() => Backup("test.txt", "backup_test.txt")),
            Task.Run(() => Console.WriteLine("Данные изменены")),
            Task.Run(() => Console.WriteLine("Данные перезаписаны изнутри"))
        };
        await Task.WhenAll(tasks);
    }
}
