namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
    { 
        ReadAndPrint();
        Write();
    }
    
    public static void Write()
    {
        string[] lines = new string[5];
        for (int i = 0; i < lines.Length; i++)
        {
            lines[i] = "text";
        }
        File.WriteAllLines("Text.txt", lines);
    }

    public static void ReadAndPrint()
    {
        string[] lines = File.ReadAllLines("Text.txt");
        foreach(string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}
