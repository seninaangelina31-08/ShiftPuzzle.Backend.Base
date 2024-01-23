namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
    { 
        WriteToFile();
        ReadFromFileAndPrint();
    }

    public static void WriteToFile()
    {
        string[] lines = new string[5];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = "Vanya";
        }
        File.WriteAllLines("name.txt", lines);
    }

    public static void ReadFromFileAndPrint()
    {
        string[] lines = File.ReadAllLines("name.txt");
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
