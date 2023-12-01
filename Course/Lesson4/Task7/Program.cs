using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6};
            Console.Write("Элементы на нечётных позициях: ");
            for(int i=0; i < numbers.Length; ++i) {
                if (i % 2 != 0) {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
