using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5};
            int[] rotated_numbers = new int[5];

            Console.Write("Введите на сколько сдвигать массив: ");
            int k = Convert.ToInt32(Console.ReadLine());
            
            for (int i=0; i < numbers.Length; i++)
            {
                rotated_numbers[(i + k) % numbers.Length] = numbers[i];
            }
            
            Console.Write("Исходный массив: ");
            foreach (int number in numbers) {
                Console.Write($"{number} ");
            };
            Console.WriteLine();
            
            Console.Write($"Массив со сдвигом {k} вправо: ");
            foreach (int number in rotated_numbers) {
                Console.Write($"{number} ");
            };
            Console.WriteLine();
        }
    }
}
