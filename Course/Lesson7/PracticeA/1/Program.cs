namespace _1;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Введите число для вычисления факториала:");
    int a = Convert.ToInt32(Console.ReadLine());

    int result = Factorial(a);
    Console.WriteLine($"Факториал числа {a} равно {result}");
    }
   
    static int Factorial(int n)
    {
    if (n == 0)
        return 1;
    else
        return n * Factorial(n - 1);
    }
}