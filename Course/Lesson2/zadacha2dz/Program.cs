
Random random = new Random();
int secret = random.Next(1, 100);

Console.WriteLine("Я загадал число от 1 до 100. Попробуй угадать!");

int chis = 0;
while (chis != secret) {
    Console.Write("Введите вашу догадку: ");
    chis = Convert.ToInt32(Console.ReadLine());

    if (chis < secret) {
    Console.WriteLine("Загаданное число больше." );
    } else if (chis > secret) {
    Console.WriteLine("Загаданное число меньше.");
    }
    else {
    Console.WriteLine("число мешьне 100!!!");
    }
}

Console.WriteLine("Вы угадали! Загаданное число было " + secret + ".");
