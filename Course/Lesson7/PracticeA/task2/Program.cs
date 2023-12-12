namespace task2;

class Program
{
    static void Main(string[] args)
    {
        int n = 4;
        int result = Fib(n);
        Console.WriteLine(result);
    }
    public static int Fib(int n)
    {
        if (n <= 0)
        {
            System.Console.WriteLine("Числа Фибоначчи начинаются с 1!!!");
        }
        if (n == 1 || n == 2)
        {
            return 1;
        }
        else
        {
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
