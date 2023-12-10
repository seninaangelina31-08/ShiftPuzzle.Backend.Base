namespace _2;

class Program
{
    static void Main(string[] args)
    {
    {
        Console.Write("Введите свое имя:");
        string username = Console.ReadLine();

        GreetUser(username);
    }

    static void GreetUser(string username)
    {
        Console.WriteLine($"Привет, {username}!");
    }
}
}