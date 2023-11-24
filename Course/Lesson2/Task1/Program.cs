namespace Task1;
class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Введите своя имя: ");
        string name = Console.ReadLine() ?? "";
        Console.WriteLine("Привет, " + name + '!');
    }
}
