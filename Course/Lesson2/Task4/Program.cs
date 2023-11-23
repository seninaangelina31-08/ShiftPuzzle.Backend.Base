namespace Task4;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Введите текст: ");
        string text = Console.ReadLine();

        if (text == "")
        {
            Console.WriteLine("Скорее всего, вы нажали на Enter");

        }
        else 
        {
            Console.WriteLine("Вы ввели не Enter");

        }
    }
}
