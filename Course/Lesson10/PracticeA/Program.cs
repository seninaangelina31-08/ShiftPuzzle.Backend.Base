using System;
using System.IO;

namespace PracticeA
{
    class FileOperations
    {
        static void Main(string[] args)
        { 
            string path = "test.txt";

            File.WriteAllText(path, "test");

            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }
    }
}