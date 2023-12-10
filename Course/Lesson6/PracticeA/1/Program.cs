namespace _1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число:");
        int one = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число:");
        int two = Convert.ToInt32(Console.ReadLine());
        
        int result = Sum(one, two);
        Console.WriteLine(result);
    }

    static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }
}