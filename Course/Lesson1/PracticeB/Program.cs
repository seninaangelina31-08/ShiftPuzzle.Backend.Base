namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        double div = num1 / num2;
        Console.WriteLine("Сумма: " + (num1 + num2));
        Console.WriteLine("Разность: " + (num1 - num2));
        Console.WriteLine("Произведение: " + (num1 * num2));
        Console.WriteLine("Частное: " + (div));
    }
}
