using System;

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введи что-нибудь: ");
            string user_text = Console.ReadLine() ?? "";
            Console.Write("Ты ввёл: " + user_text);
        }
    }
}
