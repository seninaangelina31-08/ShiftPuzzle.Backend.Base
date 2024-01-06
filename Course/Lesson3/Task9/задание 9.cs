using System;

class Program
{
    static void Main()
    {
        int[] array = new int[5] { 10, 20, 30, 40, 50 };
        foreach (int number in array)
        {
            Console.WriteLine(number);
        }
    }
}
