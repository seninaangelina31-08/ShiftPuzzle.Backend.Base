namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
    { 
        WriteToFile("test");
        ReadFromFileAndPrint("test.txt");
    }

    public static void WriteToFile(string text)
    {
        string[] lines = new string[5];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = $"{text} {i+1}";
        }
        File.WriteAllLines("test.txt", lines);
    }

    public static void ReadFromFileAndPrint(string name_file)
    {
        string[] lines = File.ReadAllLines(name_file);
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
