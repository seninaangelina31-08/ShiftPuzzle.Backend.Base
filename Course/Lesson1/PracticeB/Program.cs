namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {
        // Ввод двух чисел с клавиатуры
        Console.Write("Введите первое число: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        // Выполнение арифметических операций и вывод результатов на экран
        Console.WriteLine("Сумма чисел: " + (number1 + number2));
        Console.WriteLine("Разность чисел: " + (number1 - number2));
        Console.WriteLine("Произведение чисел: " + (number1 * number2));
        Console.WriteLine("Частное чисел: " + (number1 / number2));
    }
}
