namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
    {
        WriteToFile();
        ReadFromFileAndPrint();
        // чтение запись в файл test.txt
    }
    
    public static void WriteToFile()
    {
        string[] lines = new string[5];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = "test";
        }
        File.WriteAllLines("Test.txt", lines);
    }

    public static void ReadFromFileAndPrint()
    {
        string[] lines = File.ReadAllLines("Test.txt");
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
