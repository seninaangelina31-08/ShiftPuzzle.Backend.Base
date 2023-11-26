namespace homw_task2;

using System;

class Program
{
    static void Main()
    {
        int my_num = 15;
        Console.WriteLine("Угадайте число от 1 до 50");
        int user_num;
        bool answer = false;

        while (!answer)
        {
            Console.Write("Введите ваше предположение: ");
            user_num = Convert.ToInt32(Console.ReadLine());

            if (user_num > my_num)
            {
                Console.WriteLine("Нет, моё число меньше");
            }
            else if (user_num < my_num)
            {
                Console.WriteLine("Нет, моё число больше");
            }
            else
            {
                Console.WriteLine("Да, вы угадали");
                answer = true;
            }
        }

    }
}

