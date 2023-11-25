namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте! Введите своё имя: ");
        string name = Console.ReadLine() ?? "";
        Console.WriteLine("Здравствуйте, " + name + '!');
    }
}
