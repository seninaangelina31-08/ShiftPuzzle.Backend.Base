namespace PracticeC;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите строку, содержащую число: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int number))
        {
            int convertedNumber = number + 5;
            Console.WriteLine("Результат: " + convertedNumber);
        }
        else
        {
            Console.WriteLine("Ошибка! Невозможно сконвертировать в целое число.");
        }
    }
}
