// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace PracticeABC;

﻿using System;
using System.IO;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string sourceFilePath = "file/source.txt";
        string backupFilePath = "file/backup.txt";
        string tempFilePath = "file/temp.txt";

        Thread thread1 = new Thread(() =>
        {
            File.Copy(sourceFilePath, backupFilePath, true);
            Console.WriteLine("Резервное копирование завершено.");
        });

        Thread thread2 = new Thread(() =>
        {
            string content = File.ReadAllText(sourceFilePath);
            content = content.Replace("oldText", "newText");
            File.WriteAllText(tempFilePath, content);
            Console.WriteLine("Данные изменены.");
        });

        Thread thread3 = new Thread(() =>
        {
            string newContent = File.ReadAllText(tempFilePath);
            File.WriteAllText(sourceFilePath, newContent);
            Console.WriteLine("Данные перезаписаны.");
        });

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Все потоки завершили работу.");
    }
}