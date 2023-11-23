namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваше имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("Введите ваш телефон: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine(name + " - " + phoneNumber);
    }
}
