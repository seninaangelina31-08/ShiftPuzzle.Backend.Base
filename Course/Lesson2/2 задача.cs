using System;
namespace task 2;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите год вашего рождения:");
        int yearOfBirth = Convert.ToInt32(Console.ReadLine());
        int age = 2023 - yearOfBirth;
        Console.WriteLine("Вам " + age + " лет.");
    }
}