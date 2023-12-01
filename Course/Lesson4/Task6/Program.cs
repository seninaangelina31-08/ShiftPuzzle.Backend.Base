using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6};
            Console.Write("Введите число для поиска: ");
            string user_input = Console.ReadLine() ?? "";
            if (user_input.Length > 0) {
                int target = Convert.ToInt32(user_input);
                int counter = 0;
                while (counter < numbers.Length && numbers[counter] != target) {
                    ++counter;
                }
                if (counter == numbers.Length) {
                    Console.Write("Не найдено");
                }
                else {
                    Console.Write(counter);
                }
            }
        }
    }
}
