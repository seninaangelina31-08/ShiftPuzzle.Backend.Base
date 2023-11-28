namespace _1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        double firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double secondNumber = Convert.ToDouble(Console.ReadLine());

        double sum = firstNumber + secondNumber;
        Console.WriteLine("Сумма чисел равна: " + sum);
    }
}
