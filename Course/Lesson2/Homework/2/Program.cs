namespace _2;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int secretNumber = random.Next(1, 11); // загадываем число от 1 до 10
        
        int guess = 0;
        bool correctGuess = false;

        Console.WriteLine("Я загадал число от 1 до 10. Попробуйте угадать.");

        while (!correctGuess)
        {
            Console.Write("Введите ваше предположение: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < secretNumber)
            {
                Console.WriteLine("Загаданное число больше вашего предположения.");
            }
            else if (guess > secretNumber)
            {
                Console.WriteLine("Загаданное число меньше вашего предположения.");
            }
            else
            {
                correctGuess = true;
                Console.WriteLine("Поздравляю! Вы угадали число.");
            }
        }

        Console.WriteLine("Игра окончена. Спасибо за игру!");
    }
}
