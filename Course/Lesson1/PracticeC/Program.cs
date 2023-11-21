namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        string num = Console.ReadLine();
        Console.WriteLine("Ваше число в типе int: " + Convert.ToInt32(num) * 5);

    }
}
