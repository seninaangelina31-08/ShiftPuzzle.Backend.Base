namespace L7_T1;

class Program
{
    public static int Factorial(int num)
    {
        if (num <= 1) return 1;
        else return num * Factorial(num - 1);
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Введите число, факториал которого надо вывести");
        int answer = Factorial(Convert.ToInt16(Console.ReadLine()));
        Console.WriteLine(answer);
    }
}
