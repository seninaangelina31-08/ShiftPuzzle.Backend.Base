namespace Task5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Привет, меня зовут 'Заметки v 0.0.0.1 beta alpha'");
        Console.WriteLine("Я могу сохранить текст, который вы мне напишите!");
        Console.Write("Введите ваш текст: ");
        string text = Console.ReadLine() ?? "";
        Console.Write("Вот ваш текст: " + text);
    }
}
