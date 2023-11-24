namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Дорогой пользователь, введите свой год рождения: ");
        int year = Convert.ToInt32(Console.ReadLine()) ?? "";
        int cur_year = DateTime.Now.Year;
        Console.Write("Я считаю, что вам: " + (cur_year - year) + " лет )");
    }
}
