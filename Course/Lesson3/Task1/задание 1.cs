using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}