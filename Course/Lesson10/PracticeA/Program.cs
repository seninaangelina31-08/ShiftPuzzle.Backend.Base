namespace PracticeA;
using System;
using System.IO;


class FileOperations
{
    static void Main(string[] args) { 
        string[] lines = new string[5];
        for (int i = 0; i < lines.Length; i++) {
            lines[i] = "aaaaaa";
        }
        File.WriteAllLines("test.txt", lines);

        string[] strs = File.ReadAllLines("test.txt");
        foreach(string line in strs){
            Console.WriteLine(line);
        }
    }
}
