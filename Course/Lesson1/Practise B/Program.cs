namespace Practise_B;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите 1 число:");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 число:");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма {num1 + num2}");
Console.WriteLine($"Вычитание {num1 - num2}");
Console.WriteLine($"Деление {num1 / num2}");
Console.WriteLine($"Умножение {num1 * num2}");
    }
}
