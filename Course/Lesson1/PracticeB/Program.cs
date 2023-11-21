namespace PracticeB;
class Program
{
    static void Main(string[] args)
    {   
        int a, b;
        Console.Write("Введите число: ");
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите второе число: ");
        b = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine((a + b));
        Console.WriteLine((a - b));
        Console.WriteLine((a * b));
        Console.WriteLine((a / b));
    }
}
