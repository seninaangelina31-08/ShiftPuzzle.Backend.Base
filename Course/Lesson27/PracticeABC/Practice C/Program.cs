using System;
using System.IO;
using System.Threading.Tasks;

namespace Practice_C;

class Program
{
    static async Task Backup(string path)
    {
        using (var reader = new StreamReader(path))
        {
            string line;
            string Line = "";
            while ((line = reader.ReadLine()) != null)
            {
                Line += line + "\n";
            }
            using (var writer = new StreamWriter("C:\\Users\\Матигоров Никита\\Source\\Repos\\AyyGee18\\ShiftPuzzle.Backend.Base\\Course\\Lesson27\\PracticeABC\\Practice C\\TestBackup.txt"))
            {
                await writer.WriteAsync(Line);
            }
        }
        
    }

    static async Task EditData(string path)
    {
        using (var reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line + " //Edit stroke");
            }
        }
    }

    static string OverwriteEdit(string path)
    {
        string Line = "";
        using (var reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Line += line + " overwrite\n";
            }
        }
        return Line;
    }

    static async Task WriteToFile(string path)
    {
        string Line = OverwriteEdit(path);
        using (var writer = new StreamWriter(path))
        {
            await writer.WriteAsync(Line);
        }
    }
    static async Task Overwrite(string path)
    {
        await WriteToFile(path);
    }


    static async Task Main(string[] args)
        {
            string path = "C:\\Users\\Матигоров Никита\\Source\\Repos\\AyyGee18\\ShiftPuzzle.Backend.Base\\Course\\Lesson27\\PracticeABC\\Practice C\\Test.txt";
            Task[] tasks = new Task[]
            {
                Task.Run(() => Backup(path)),
                Task.Run(() => EditData(path)),
                Task.Run(() => Overwrite(path))
            };
            await Task.WhenAll(tasks);
        }
}
