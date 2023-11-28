using System;

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи 1-е число: ");
            string a = Console.ReadLine() ?? "0";
            Console.Write("Введи 2-е число: ");
            string b = Console.ReadLine() ?? "0";

            Console.Write("Сумма чисел: " + Convert.ToString(Convert.ToInt64(a) + Convert.ToInt64(b)));
        }
    }
}
