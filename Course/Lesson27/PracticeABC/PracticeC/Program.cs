﻿using System;
using System.IO;
using System.Threading.Tasks;

namespace PracticeC
{
    class Program
    {
        public static async Task BackUp(string filePath="file.txt", string backupFilePath="backup.txt")
        {
            using (var reader = new StreamReader(filePath))
            {
                string data = await reader.ReadToEndAsync(); 
                
                using (var writer = new StreamWriter(backupFilePath))
                {
                    await writer.WriteAsync(data);  
                    Console.WriteLine("Резервное копирование выполнено");
                }
            }
        }


        public static async Task ChangeData()
        {
            Console.WriteLine("Данные изменены");
        }

        public static async Task RewriteData()
        {
            Console.WriteLine("Данные перезаписаны");
        }


        static async Task Main(string[] args)
        {
            Task[] tasks = new Task[]
            {
                Task.Run(() => BackUp()),
                Task.Run(() => ChangeData()),
                Task.Run(() => RewriteData())
            };
            await Task.WhenAll(tasks);
        }
    }
}