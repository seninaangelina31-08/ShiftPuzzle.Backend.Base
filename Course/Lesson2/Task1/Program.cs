using System;

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Привет, как тебя зовут? ");
            string user_name = Console.ReadLine() ?? "Человек";

            Console.Write("Привет, " + user_name + "!");
        }
    }
}
