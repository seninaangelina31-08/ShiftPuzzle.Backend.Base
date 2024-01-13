namespace PracticeA;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public class FileIO
    {
        public static void WriteToFile(string[] lines, string name)
        {
            File.WriteAllLines(name, lines);
        }

        public static string[] ReadFromFile(string name)
        {
            return File.ReadAllLines(name);
        }
    }
}
