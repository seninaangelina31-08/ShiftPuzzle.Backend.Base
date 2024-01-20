Console.WriteLine("Задача на вычисление факториала");

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = factorial(n);
Console.WriteLine($"Факториал числа {n} равен {result}");

static int factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }
    else
    {
        return n * factorial(n-1);
    }
}
