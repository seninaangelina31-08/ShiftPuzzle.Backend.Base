using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 3, 7, 5, 8, 2, 9 };
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            else if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine("Минимальный элемент: " + min);
        Console.WriteLine("Максимальный элемент: " + max);
    }
}



