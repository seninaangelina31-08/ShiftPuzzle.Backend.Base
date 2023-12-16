namespace Task2;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Введите число для вычисления число Фибоначчи:");
    int a = Convert.ToInt32(Console.ReadLine());

    int result = fibo(a);
    Console.WriteLine($"Число фибоначи {result}");
    }
    static int fibo(int n)
{
    if (n <= 1)
        return n; 
    return fibo(n - 1) + fibo(n - 2); 
}
}
