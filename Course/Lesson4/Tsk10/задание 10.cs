using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[] numbers = { 1, -2, 3, -4, 5 };

        
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                numbers[i] = 0;
            }
        }

        
        Console.WriteLine("Измененный массив:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
