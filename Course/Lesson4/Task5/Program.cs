using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {-1, 2, -3, 4, 5, -6};
            int negative_numbers_amount = 0;
            
            foreach(int number in numbers) {
                if(number < 0) {
                    negative_numbers_amount++;
                }
            }
            Console.Write($"Отрицательных чисел в массиве: {negative_numbers_amount}");
        }
    }
}
