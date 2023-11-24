using System;
using System.Collections.Generic; 

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string command;
            Console.WriteLine("Привет, я считалка количества нажатий, жмякай Enter сколько хочешь, а я буду тебе выводить, сколько раз ты это делал");
            Console.WriteLine("Как надоест напиши 'Выйти'");
            while (true) {
                Console.Write("Введи что-нибудь: ");
                command = Console.ReadLine() ?? "";
                if (command == "Выйти") {
                    Console.WriteLine("До встречи!!!");
                    break;
                }
                else {
                    counter++;
                    Console.WriteLine("Ты ударил клавишу " + Convert.ToString(counter) + "раз!!!");
                }
            }
        }
    }
}
