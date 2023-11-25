namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сюда абсолютно любой текст: ");
        string text = Console.ReadLine() ?? "";
        Console.Write("Вы написали:   " + text);
    }
}
