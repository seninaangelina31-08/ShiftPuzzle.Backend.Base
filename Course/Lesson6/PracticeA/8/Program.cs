namespace _8;

class Program
{
    static void Main()
    {

        int number = 5;
        long factorial = CalculateFactorial(number);
        Console.WriteLine($"Факториал числа {number} = {factorial}");
    }

    static long CalculateFactorial(int n)
    {
        if (n < 0)
        {
            throw new ArgumentException("Факториал отрицательного числа не определен");
        }
        if (n == 0 || n == 1)
        {
            return 1;
        }
        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }
}