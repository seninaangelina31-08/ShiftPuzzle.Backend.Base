Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isEven = IsEven(number);
Console.WriteLine($"Число {number} четное: {isEven}");

static bool IsEven(int number)
{
    return number % 2 == 0;
}