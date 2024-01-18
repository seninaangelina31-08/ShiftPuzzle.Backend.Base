namespace PracticeA;
class FileOperations
{

    public static void Writes()
    {
        string[] strs = new string[10];
        for (int i = 0; i < strs.Length; i++)
        {
            strs[i] = $"Primer_stroki {i}";
        }

        File.WriteAllLines("Test.txt", strs);        
    }

    public static string[] Read()
    {
        return File.ReadAllLines("Test.txt");
    }
    static void Main(string[] args)
    {   
        Writes();
        string[] file = Read();
        
        foreach (string el in file)
        {
            Console.WriteLine(el);
        }
    }
}
