namespace PracticeB;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите год вашего рождения: ");
        int bd_year = Convert.ToInt16(Console.ReadLine());
        int year = Convert.ToInt16(DateTime.Now.Year);
        int age = year - bd_year;
        Console.WriteLine($"Привет, тебе {age-1}-{age}");
    }
}
