namespace Homework_Tsk_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Это программа отгадай число от 1 до 10");
        Console.Write("Пишите ваш вариант: ");
        int user_ans = Convert.ToInt32(Console.ReadLine());

        int ans = 7;
        if (user_ans > ans)
        {
            Console.WriteLine("Загадананое число меньше");
            }
        
        else if (user_ans < ans)
        {
            Console.WriteLine("Загадананое число больше");
            }

        else
        {
            Console.WriteLine("вы угадали!");
            }

    }
}
