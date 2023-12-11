namespace HomeworkA;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Привет это калькулятор сложения");
        Console.WriteLine("Введи первое число:");
        int one = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введи второе число:");
        int two = Convert.ToInt32(Console.ReadLine());

        int result = one + two;

        Console.WriteLine($"Результат сложения: {one} + {two} = {result}");

    }
}
