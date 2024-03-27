using System;
using System.Threading.Tasks;
using System.Timers;  
public class Program
{
    public static async Task Reserve(string path)
    {
        File.Copy(path, "backup_" + path, true);
        Console.WriteLine($"Файл {path} успешно скопирован.");
    }

    public static async Task Update(string path)
    {
        string content = File.ReadAllText(path);
        content = content.Replace("oldText", "newText");
        File.WriteAllText("temp_" + path, content);
        Console.WriteLine("Данные в файле изменены.");
    }

    public static async Task Rewrite(string path)
    {
        string newContent = File.ReadAllText("temp_" + path);
        File.WriteAllText(path, newContent);
        Console.WriteLine($"Данные в файле {path} перезаписаны.");
    }

    static void Main()
    {
        string filePath = "test.txt";

        Task task1 = Task.Run(async () => await Reserve(filePath));
        Task task2 = Task.Run(async () => await Update(filePath));
        Task task3 = Task.Run(async () => await Rewrite(filePath));

        Task.WhenAll(task1, task2, task3);
    }
}