namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введи свой год рождения: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("тебе "+(2023-age)+" лет!");
    }
}
