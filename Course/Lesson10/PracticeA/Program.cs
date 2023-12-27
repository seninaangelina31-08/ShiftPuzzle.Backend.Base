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
        string[] lines = new string[3];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = (i + 1) + ") string";
        }
        File.WriteAllLines("test.txt", lines);
    }

    public static void ReadFromFileAndPrint()
    {
        string[] lines = File.ReadAllLines("test.txt");
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
