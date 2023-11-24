namespace Hw_1;
class Program
{
    static void Main(string[] args)
    {
        double a, b;
        string str = "0";
        Console.WriteLine("Добро пожаловать в калькулятор!");
        Console.Write("Введите ваше первое число: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите ваше второе число: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Сумма ваших двух чисел: " + (a + b));
        
    }
}
