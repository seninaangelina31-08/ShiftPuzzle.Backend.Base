using System;

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentYear = DateTime.Now.Year;
            Console.Write("Привет, введи свой год рождения: ");
            string user_birth_year = Console.ReadLine() ?? "";

            if (user_birth_year.Length == 0) {
                Console.Write("Что-то ты не разговорчивый :(");
            }
            else if (Convert.ToInt64(user_birth_year) > currentYear) {
                Console.Write("А ты смотрю ещё не родился )))");
            }
            else {
                Console.Write("Твой возраст: ");
                Console.Write(currentYear - Convert.ToInt64(user_birth_year));
            }

            
        }
    }
}
