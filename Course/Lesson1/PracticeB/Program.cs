namespace PracticeB;
class Program
{
    static void Main(string[] args)
    {   Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Сумма: " + (a + b));
        Console.WriteLine("Разность: " + (a - b));
        Console.WriteLine("Произведение: " + (a * b));
        
        if (b != 0)
        {
            Console.WriteLine("Частное: " + (a / b));
        }
        else
        {
            Console.WriteLine("На ноль делить нельзя");
        }
    }
}
