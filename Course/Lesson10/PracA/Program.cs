namespace PracticeA;
class FileOperations
{

    public static void WriteToFile()
    {
        string[] lines = new string[3];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = "Alice, 24";
        }
        File.WriteAllLines("lesson10.txt", lines);
    }


    public static void ReadFromFileAndPrint()
    {
        string[] lines = File.ReadAllLines("lesson10.txt");
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }

    static void Main(string[] args)
    { 

        WriteToFile();
        ReadFromFileAndPrint();
    }
}

