using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[] { 10, 20, 30, 40, 50 };
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine("Сумма всех элементов: " + sum);
    }
}