using System;

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 1-е число: ");
            int first_number = int.Parse(Console.ReadLine());
            Console.Write("Введите 2-е число (ПОЖАЛУЙСТА, НЕ НОЛЬ!!!): ");
            int second_number = int.Parse(Console.ReadLine());

            Console.Write("Сложение: ");
            Console.Write(first_number + second_number);
            Console.WriteLine(".");
            Console.Write("Вычитание: ");
            Console.Write(first_number - second_number);
            Console.WriteLine(".");
            Console.Write("Умножение: ");
            Console.Write(first_number * second_number);
            Console.WriteLine(".");
            Console.Write("Деление: ");
            Console.Write(first_number / second_number);
            Console.WriteLine(".");
        }
    }
}
