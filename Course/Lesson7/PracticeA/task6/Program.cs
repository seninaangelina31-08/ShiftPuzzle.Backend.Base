using System;
namespace task6;

class Program
{
    static void Main(string[] args)
    {
        string str = "Hello";
        System.Console.WriteLine(pal(str, 0, str.Length - 1));
    }
    public static bool pal(string str, int start, int end)
    {
        if (start >= end)
            return true;
        if (str[start] != str[end])
            return false;

        return pal(str, start + 1, end - 1);
    }

    
}
