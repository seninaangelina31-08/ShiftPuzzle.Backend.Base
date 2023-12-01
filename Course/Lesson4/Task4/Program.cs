using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6};
            Console.Write($"Чётные числа в массиве: ");
            foreach(int number in numbers) {
                if(number % 2 == 0) {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
