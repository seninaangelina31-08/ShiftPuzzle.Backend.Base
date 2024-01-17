Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

long factorial = CalculateFactorial(number);
Console.WriteLine($"Факториал числа {number} равен {factorial}");

static long CalculateFactorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

