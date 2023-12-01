using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {5959, 9885588, 784, 969};
            int max_number = numbers[0];
            foreach(int number in numbers) {
                if(number > max_number) {
                    max_number = number;
                }
            }
            Console.WriteLine($"Максимальный элемент массива = {max_number}");
        }
    }
}
