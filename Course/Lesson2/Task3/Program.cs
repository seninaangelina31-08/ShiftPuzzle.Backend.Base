namespace Task3;
class Program
{
    static void Main(string[] args)
    {
        string name, number;
        Console.Write("Введите имя пользователя: ");
        name = Console.ReadLine() ?? "";
        Console.Write("Введите номер телефона этого пользователя: ");
        number = Console.ReadLine() ?? "";
        Console.WriteLine("Пользователь " + name + " добавлен в ваши контакты.");
        Console.Write("Номер телефона этого пользователя: " + number);

    }
}
