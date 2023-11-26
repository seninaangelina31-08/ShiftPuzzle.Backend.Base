namespace ShiftPuzzle.Backend.Base;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое число: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double result = a + b;
        
        Console.WriteLine("Сумма введенных вами чисел: " + result);
}
}