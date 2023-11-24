namespace Hw_2;

class Program
{
    static void Main(string[] args)
    {   Random random = new Random();
        int secret_number = random.Next(1, 101);

        int guess;
        int attempts = 0;

        Console.WriteLine("Угадайте число от 1 до 100.");
        do
        {
            Console.Write("Введите вашу догадку: ");
            guess = Convert.ToInt32(Console.ReadLine());

            attempts += 1;

            if (guess < secret_number)
            {
                Console.WriteLine("Загаданное число больше.");
            }
            else if (guess > secret_number)
            {
                Console.WriteLine("Загаданное число меньше.");
            }
            else
            {
                Console.WriteLine($"Поздравляем! Вы угадали число {secret_number} за {attempts} попыток.");
            }
        } while (guess != secret_number);

        Console.ReadLine();
    }
}

