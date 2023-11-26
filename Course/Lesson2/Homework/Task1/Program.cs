namespace task1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Сумма чисел {a} и {b} = {a+b}");
    }
}
