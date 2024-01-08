using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        double num1 = double.Parse(Console.ReadLine()); // читаем первое число с консоли и преобразуем его в тип double

        Console.WriteLine("Введите второе число:");
        double num2 = double.Parse(Console.ReadLine()); // читаем второе число с консоли и преобразуем его в тип double

        double sum = num1 + num2; // складываем два числа

        Console.WriteLine("Результат сложения: " + sum); // выводим результат на консоль

        Console.ReadLine(); // ожидаем нажатия клавиши, чтобы программа не закрылась сразу
    }
}
