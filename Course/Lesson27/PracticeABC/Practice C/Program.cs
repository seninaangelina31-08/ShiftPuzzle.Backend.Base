using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        string filePath = "mytextfile.txt";
        Task task1 = Task.Run(async () => await ReverseCopy(filePath));
        Task task2 = Task.Run(async () => await ModifyData(filePath));
        Task task3 = Task.Run(async () => await RewriteData(filePath));

        await Task.WhenAll(task1, task2, task3);
    }

    public static async Task ReverseCopy(string filePath)
    {
        Console.WriteLine($"Файл {filePath} скопирован");
    }

    public static async Task ModifyData(string filePath)
    {
        Console.WriteLine($"Данные в файле {filePath} изменены");
    }
    public static async Task RewriteData(string filePath)
    {
        Console.WriteLine($"Данные в файле {filePath} перезаписаны");
    }
}
