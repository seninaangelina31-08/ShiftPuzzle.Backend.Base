﻿namespace L4_T2;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {123, 12412, 12513, 12315134, 123};
        int biggest = numbers[0];
        foreach (int num in numbers)
        {
            if (num > biggest)
            {
                biggest = num;
            }
        }
        Console.WriteLine(biggest);
    }
}