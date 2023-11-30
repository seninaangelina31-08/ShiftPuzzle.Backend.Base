namespace Task2;

class Program
{
    static void Main(string[] args)
    {
Console.Write("Введите Ваш год рождения: ");
int data = Convert.ToInt32(Console.ReadLine());
 int year = 2023;
Console.WriteLine($"Вам {year - data} лет");
    }
}
