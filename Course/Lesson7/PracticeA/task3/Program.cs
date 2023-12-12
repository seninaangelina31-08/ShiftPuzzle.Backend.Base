namespace task3;

class Program
{
    static void Main(string[] args)
    {
        string original = "Hello, World!";
        string reversed = RevStr(original);
        Console.WriteLine(reversed);
    }
    public static string RevStr(string original)
    {
        if (original.Length <= 1)
        {
            return original;
        }
        return RevStr(original.Substring(1)) + original[0];
    }
}
