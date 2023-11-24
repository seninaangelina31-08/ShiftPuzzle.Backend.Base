namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int current_year = 2023;
        Console.WriteLine("Введите год своего рождения:");
        int year = Convert.ToInt32(Console.ReadLine());
        int age = current_year - year;
        Console.WriteLine("Вам " + age + " лет!");

    }
}
