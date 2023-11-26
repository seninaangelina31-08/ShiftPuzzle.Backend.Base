namespace homw_task1;

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Напишите первое число");
        double num1 = Convert.ToDouble(Console.ReadLine()); 
        Console.WriteLine("Напишите второе число");
        double num2 = Convert.ToDouble(Console.ReadLine());
        double result = 0;
        result = num1 + num2;
        Console.WriteLine(result);
    }
}
