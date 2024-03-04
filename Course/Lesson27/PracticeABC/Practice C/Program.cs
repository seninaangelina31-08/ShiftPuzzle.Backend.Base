// See https://aka.ms/new-console-template for more information
using namespace PracticeABC;
using System;
using System.Threading.Tasks;

class Program {



    static async Task ExtremeReadAsync(string filePath)
    {
        using (var reader = new StreamReader(filePath))
        {
            var content = reader.ReadToEndAsync();
            Console.WriteLine(content);
        }
    }

    
    public static async void main() {
        Task tasks = new Task[] {
            Task.Run(ExtremeReadAsync("task.txt")),
            Task.Run(() => {Console.WriteLine("Данные изменены")}),
            Task.Run(() => {Console.WriteLine("Данные перезаписанны")})
        };
        await Task.WhenAll(tasks);
    }

}