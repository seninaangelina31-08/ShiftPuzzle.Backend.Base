namespace PracticeA_hm;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Программа: простейший калькулятор");
        Console.WriteLine("Введите первое число:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Сумма двух ваших чисел: " + (num1 + num2));
    }
}
