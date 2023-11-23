namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите год вашего рождения: ");
        int year = Convert.ToInt16(Console.ReadLine());
        int correct_year = 2023;
        Console.WriteLine("Вам " + (correct_year - year) + " лет.");
    }
}
