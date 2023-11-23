namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        
        // Преобразуем строку в целое число
        int number = (int)Convert.ToInt64(Console.ReadLine());
        
        // Увеличиваем число на 5
        number += 5;
        
        Console.WriteLine("Результат: " + number);

    }
}
