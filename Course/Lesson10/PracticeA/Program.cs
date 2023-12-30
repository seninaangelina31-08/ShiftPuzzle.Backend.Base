using System;
using System.IO;
namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
{ 
    
        WriteToFile();
        ReadAllFiles();
}


public static void WriteToFile()
{
string[] new_file = new string[10];
for(int i = 0; i < new_file.Length; i++)
{
    new_file[i] = "С Новым годом!!!!!";
}
File.WriteAllLines("Congratilation.txt", new_file);
}

public static void ReadAllFiles()
{
    string[] new_file = File.ReadAllLines("Congratilation.txt");
    foreach (string i in new_file)
    {
        Console.WriteLine(i);
    }
}


}
