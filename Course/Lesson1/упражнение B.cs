using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine());

        double sum = num1 + num2;
        double difference = num1 - num2;
        double product = num1 * num2;
        double quotient = num1 / num2;

        Console.WriteLine("Сумма: " + sum);
        Console.WriteLine("Разность: " + difference);
        Console.WriteLine("Произведение: " + product);
        Console.WriteLine("Частное: " + quotient);
    }
}
