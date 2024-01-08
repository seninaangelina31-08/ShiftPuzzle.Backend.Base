using System;
using System.IO;

namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
    { 

        string fp = "test.txt";

            // Writing to the file
        string write = "Meooooooooooooooooooooooooow heheheh";
        File.WriteAllText(fp, write);

            // Reading from the file
        string read = File.ReadAllText(fp);
        Console.WriteLine(read);
        // чтение запись в файл test.txt
    }
}
