namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте! Я буду выполнять арифметические операции над числами!");
        Console.WriteLine("Введите первое целое число:");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите второе целое число:");
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Сложение: " + (num1 + num2));
        Console.WriteLine("Вычитание: " + (num1 - num2));
        Console.WriteLine("Умножение: " + (num1 * num2));
        Console.WriteLine("Целое от деления: " + (num1 / num2));
        Console.WriteLine("Возведение в степень: " + (Math.Pow(num1, num2)));

    }
}
