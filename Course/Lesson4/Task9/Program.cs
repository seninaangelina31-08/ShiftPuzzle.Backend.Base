using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сортировка пузырьком
            int[] numbers = {5595149, 1, 2, 55, 6, 1, 8, 9};
            int b;
            for(int i = 0; i < numbers.Length - 1; ++i) {
                for(int j = 0; j < numbers.Length - 1 - i; ++j) {
                    if(numbers[j] > numbers[j + 1]) {
                        b = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = b;
                    }
                }
            }
                
            Console.Write($"Отсортированный массив = [ ");
            foreach(int number in numbers) {
                Console.Write($"{number} ");
            }
            Console.Write($"]");
        }
    }
}
