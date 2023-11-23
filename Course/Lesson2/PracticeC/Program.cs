namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите имя:");
        string name = Console.ReadLine();
        
        Console.WriteLine("Введите номер телефона:");
        int phone_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ваше имя: " + name);
        Console.WriteLine("Ваше имя: " + phone_num);
    }
}
