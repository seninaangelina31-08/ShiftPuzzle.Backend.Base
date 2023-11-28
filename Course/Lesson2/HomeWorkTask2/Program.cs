using System;

namespace ShiftPuzzle.Backend.Base
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int random_value = rnd.Next(0, 100);
            string user_ans;

            Console.WriteLine("Привет, ахахах, я загадал чслучайное число от 1 до 100, и пока ты его не назовёшь, я тебя не выпущу )))");
            while (true) {
                Console.Write("Введи число: ");
                user_ans = Console.ReadLine() ?? "";
                if (user_ans.Length == 0) {
                    Console.Write("");
                } else {
                    if (Convert.ToInt64(user_ans) < random_value) {
                        Console.WriteLine("Больше");
                    } else if (Convert.ToInt64(user_ans) > random_value) {
                        Console.WriteLine("Меньше");
                    }
                    else {
                        Console.WriteLine("Угадал, повезло, повезло )))");
                        break;
                    }
                }
            }
        }
    }
}
