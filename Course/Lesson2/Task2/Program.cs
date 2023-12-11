namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите год рождения: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year < 2023)
        {
            Console.WriteLine(2023 - year);   
        }
        else
        {
            Console.WriteLine("Год рождения введён некоректо! Введите ещё раз");
        }
        
    }
}
