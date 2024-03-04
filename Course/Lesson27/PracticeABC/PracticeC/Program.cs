namespace practicec;
using System.IO;
using System.Threading.Tasks;

class Program
{

    static async Task CopyFile(string pathFile)
    {
        string content;
        using (var reader = new StreamReader(pathFile))
        {
            content = await reader.ReadToEndAsync();
        }
        Console.WriteLine("Файл успешно считан");

        using (var writer = new StreamWriter($"{1}copy.txt"))
        {
            await writer.WriteAsync(content);
        }
        Console.WriteLine("Файл успешно записан.");
    }

    static async Task Main(string[] args)
    {
        string pathToFile = "1.txt";
        Task[] tasks = new Task[]
        {
            Task.Run(async () => await CopyFile(pathToFile)),
            Task.Run(() => Console.WriteLine("Данные в файле меняются")),
            Task.Run(() => Console.WriteLine("Перезапись данных в файле"))
        };

        await Task.WhenAll(tasks);
    }
}
