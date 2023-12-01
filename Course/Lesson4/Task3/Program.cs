using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6};
            int[] reversed_numbers = new int[6];
            for(int i=0; i < numbers.Length; ++i) {
                reversed_numbers[i] = numbers[numbers.Length - 1 - i];
            }
            Console.Write($"Перевёрнутый массив = [ ");
            foreach(int number in reversed_numbers) {
                Console.Write($"{number} ");
            }
            Console.Write($"]");
        }
    }
}
