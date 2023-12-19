namespace L7_T5;

class Program
{
    public static int GetNODRecurs(int val1, int val2)
    {
        if (val2 == 0)
            return val1;
        else
            return GetNODRecurs(value2, val1 % val2);
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
