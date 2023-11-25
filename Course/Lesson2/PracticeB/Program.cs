namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите год рождения:");
        
        // Чтение введенного года рождения
        int yearOfBirth = Convert.ToInt32(Console.ReadLine());
        
        // Получение текущего года
        int currentYear = DateTime.Now.Year;
        
        // Вычисление возраста
        int age = currentYear - yearOfBirth;
        
        // Вывод возраста
        Console.WriteLine($"Ваш возраст: {age} лет");
    }
}
