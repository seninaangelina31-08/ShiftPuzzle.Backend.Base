// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;
using System.Timers;  
public class Program
{
    public static async Reserve(string path)
    {
        Console.WriteLine($"Файл {path} успешно скопирован.");
    }

    public static async Update(string path)
    {
        Console.WriteLine("Данные в файле изменены.");
    }

    public static async Rewrite(string path)
    {
        Console.WriteLine($"Данные в файле {path} перезаписаны.");
    }

    static void Main()
    {
        string filePath = "test.txt";

        Task task1 = Task.Run(async () => await ReverseCopy(filePath));
        Task task2 = Task.Run(async () => await ModifyData(filePath));
        Task task3 = Task.Run(async () => await RewriteData(filePath));

        await Task.WhenAll(task1, task2, task3);
    }
}

