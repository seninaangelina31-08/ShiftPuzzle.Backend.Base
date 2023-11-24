namespace five;

class Program
{
    static void Main(string[] args)
    {   
    Console.Write("Введите любой текст: ");
    string text = Console.ReadLine()  ?? "";
    Console.WriteLine(text);
    }
}

