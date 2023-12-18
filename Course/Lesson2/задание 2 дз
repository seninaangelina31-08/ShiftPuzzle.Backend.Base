using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Генерация случайного числа от 1 до 100
            Random random = new Random();
            int randomNumber = random.Next(1, 101);

            Console.WriteLine("Загадано случайное число от 1 до 100");
            Console.WriteLine("Попробуйте угадать это число.");

            int guess;
            bool isGuessed = false;

            while (!isGuessed)
            {
                Console.Write("Введите вашу догадку: ");
                string guessString = Console.ReadLine();

                // Проверка на корректность ввода числа
                if (!int.TryParse(guessString, out guess))
                {
                    Console.WriteLine("Ошибка! Введите корректное число.");
                    continue;
                }

                if (guess == randomNumber)
                {
                    Console.WriteLine("Поздравляю! Вы угадали число.");
                    isGuessed = true;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
                else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }
            }

            Console.WriteLine("Нажмите любую клавишу чтобы выйти.");
            Console.ReadKey();
        }
    }
}
