using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        Console.WriteLine("Элементы массива на нечетных позициях:");

        for (int i = 1; i < numbers.Length; i += 2)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}