using System;
using System.IO;


namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
    { 

        public static void ReadFromFileAndPrint()
        {
            string[] lines = File.ReadAllLines("test.txt"); 
            foreach(string line in lines)
            {
                Console.WriteLine(line); 
            }
        }
    }

    public static void WriteToFile()
    {
        string[] lines = new string[5];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = "test";
        }
        File.WriteAllLines("test.txt", lines);
    }
}
