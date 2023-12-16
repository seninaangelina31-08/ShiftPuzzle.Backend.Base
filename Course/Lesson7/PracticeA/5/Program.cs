namespace _5;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Введите первое число для вычисления алгоритма Евклида:");
    int a = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число для вычисления алгоритма Евклида:");
    int b = Convert.ToInt32(Console.ReadLine());

    int result = GCD(a, b);
    Console.WriteLine($"Наибольший общий делитель чисел {a} и {b} равен: {result}");
    
    }
    static int GCD(int a, int b)
    {
        if (b == 0)
            return a;
        else
            return GCD(b, a % b);
    }
}