﻿namespace L4_T1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1, 2, 3, 4};
        int total = 0;
        for(int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];

        }
        Console.WriteLine(total);
    }
}