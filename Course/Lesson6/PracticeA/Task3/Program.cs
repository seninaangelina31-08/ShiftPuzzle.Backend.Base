namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int number1 = 10;
        int number2 = 20;
        int result = Max(number1, number2);
        Console.WriteLine($"Большее число: {result}");
    }

    static int Max(int a, int b)
    {
        return Math.Max(a, b);
    }
}
