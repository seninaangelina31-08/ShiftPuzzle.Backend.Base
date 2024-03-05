namespace PracticeABC;
using System;
using System.IO;

class Programm
{
    static async Task Main(string[] args){
        string path =  @"1.txt";
        string newPath = @"2.txt";
        Task[] tasks = new Task[]
        {
            Task.Run(() => CopyFile(path, newPath)),
            Task.Run(() => Console.WriteLine("The file was changed")),
            Task.Run(() => Console.WriteLine("The information was rewrite"))
        };
        await Task.WhenAll(tasks);
    }

    static async Task CopyFile(string path, string newPath)
    {
        FileInfo fileInf = new FileInfo(path);
        if (fileInf.Exists)
        {
            fileInf.CopyTo(newPath, true);      
   
        }
    }

}
