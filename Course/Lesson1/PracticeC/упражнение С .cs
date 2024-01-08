using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();
        
        int number;
        bool isNumber = int.TryParse(input, out number);
        
        if (isNumber)
        {
            int result = number + 5;
            Console.WriteLine("Результат: " + result);
        }
        else
        {
            Console.WriteLine("Неверный формат числа");
        }
    }
}
