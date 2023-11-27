namespace Task3;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Привет! Это контактная книга. Введи имя контакти и его номер телефона");
        Console.WriteLine("Имя: ");
        string name = Console.ReadLine();
        Console.WriteLine("Номер телефона: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Контакт: {name} {number}");
        
    }
}

