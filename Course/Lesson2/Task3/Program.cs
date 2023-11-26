namespace task3;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Введите номер телефона(без +, но с 7): ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("Номер: +" + number);
        Console.WriteLine("Имя: " + name);

    }
}
