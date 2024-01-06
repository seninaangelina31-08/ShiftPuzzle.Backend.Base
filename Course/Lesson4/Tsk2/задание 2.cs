using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 10, 20, 30, 40, 50 };
        int max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        Console.WriteLine("Максимальное значение: " + max);
    }
}