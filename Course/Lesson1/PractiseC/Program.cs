using System;

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int first_number = Convert.ToInt32(Console.ReadLine());

            first_number = first_number + 5;

            Console.WriteLine("Результат: " + Convert.ToString(first_number));
        }
    }
}
