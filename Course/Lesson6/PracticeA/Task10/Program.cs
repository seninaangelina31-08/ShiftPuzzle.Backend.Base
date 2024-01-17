Console.Write("Укажите минимальное число диапазона: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Укажите максимальное число диапазона: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int numrandom = GenerateRandomNumber(number1, number2);
Console.WriteLine($"Случайное число: {numrandom}");

static int GenerateRandomNumber(int number1, int number2)
{
    Random random = new Random();
    return random.Next(number1, number2 + 1);
    }