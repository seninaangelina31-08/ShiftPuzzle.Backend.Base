using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers_1 = {1, 2, 3, 4, 5};
            int[] numbers_2 = {6, 7, 8, 9, 10};
            int[] result = new int[numbers_1.Length + numbers_2.Length];

            numbers_1.CopyTo(result, 0);
            numbers_2.CopyTo(result, numbers_1.Length);

            Console.Write("Итоговый массив: ");
            foreach(int number in result) {
                Console.Write($"{number} ");
            }
        }
    }
}
