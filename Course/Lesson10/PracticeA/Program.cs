using System;
using System.IO;

namespace PracticeA;
class FileOperations
{
    static string _file="Text.txt";
    public static void WriteToFile()
    {
        string[] lines = new string[5];
        for (int i = 1; i <= lines.Length; i++)
        {
            lines[i-1] = "test"+i.ToString();
        }
        File.WriteAllLines(_file, lines);
    }

    public static void ReadFromFileAndPrint()
    {
        string[] lines = File.ReadAllLines(_file);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
    static void Main(string[] args)
    { 
        ReadFromFileAndPrint();
        WriteToFile();
    }
}
