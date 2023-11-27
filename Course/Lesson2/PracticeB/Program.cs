namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите год рождения:");
        
        int yearOfBirth = Convert.ToInt32(Console.ReadLine());
        
        int currentYear = DateTime.Now.Year;
        
        int age = currentYear - yearOfBirth;
        
        Console.WriteLine($"Ваш возраст: {age} лет");
    }
}
