namespace task2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите свой год рождения: ");
        int birthday = Convert.ToInt32(Console.ReadLine());
        int now = 2023;
        Console.WriteLine("Тебе сейчас " + (now - birthday) + " лет!");
    }
}
