namespace HomeworkB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, это игра 'Угадай число'");
    
            Random rnd = new Random();
            var ran = rnd.Next(1, 10);

            Console.WriteLine("Введи число от 1 до 10:");
    
            int num = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (num > ran)
                {
                    Console.WriteLine("Число больше");
                }
                else if (num < ran)
                {
                    Console.WriteLine("Число меньше");
                }
                else
                {
                    Console.WriteLine("Поздравляю, ты угадал число!");
                    break;
                }

                Console.WriteLine("Попробуй еще раз. Введи число:");
                num = Convert.ToInt32(Console.ReadLine());
            }
    
            Console.WriteLine("Программа завершена.");
        }
    }
}
