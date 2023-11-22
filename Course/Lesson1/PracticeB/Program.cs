namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Введите первое число");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(num1 + num2);
        Console.WriteLine(num1 - num2);
        Console.WriteLine(num1 * num2);
        Console.WriteLine(num1 / num2);
    }
}
