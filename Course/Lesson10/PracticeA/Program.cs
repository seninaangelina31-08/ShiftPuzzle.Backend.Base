namespace PracticeA;
class FileOperations
{
    static void Main(string[] args)
    { 
        string[] lines = new string[]{"WOW", "FONDERFUL"}
        File.WriteAllLines("test.txt", lines);
        string[] linesOut = File.ReadAllLines("test.txt");
    }
}
