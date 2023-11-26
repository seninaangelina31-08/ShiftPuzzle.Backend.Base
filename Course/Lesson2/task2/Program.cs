namespace task2;



using System;

class Program
{
    static void Main()
    {
        double age;
        Console.WriteLine("Напишите свой год рождения: ");
        double number = Convert.ToDouble(Console.ReadLine());
        age = 2023 - number;
        Console.WriteLine("Ваш возраст должен быть равен "+ age);
    }
}