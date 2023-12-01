using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {-1, 2, -3, -4, 5, 6};

            for(int i=0; i < numbers.Length; ++i) {
                if (numbers[i] < 0) {
                    numbers[i] = 0;
                }
            }

            Console.Write($"Отредактированный массив = [ ");
            foreach(int number in numbers) {
                Console.Write($"{number} ");
            }
            Console.Write($"]");
        }
    }
}
