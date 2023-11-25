namespace PracitceC;

class Program
{
    static void Main(string[] args)
    {
        string names1, names2, names3;
        string phoneNumbers1, phoneNumbers2, phoneNumbers3;

        Console.WriteLine("Введите данные для 3 контактов:");

        Console.WriteLine("\nКонтакт 1:");
        
        Console.WriteLine("Введите имя:");
        names1 = Console.ReadLine();
        
        Console.WriteLine("Введите телефонный номер:");
        phoneNumbers1 = Console.ReadLine();

        Console.WriteLine("\nКонтакт 2:");
        
        Console.WriteLine("Введите имя:");
        names2 = Console.ReadLine();
        
        Console.WriteLine("Введите телефонный номер:");
        phoneNumbers2 = Console.ReadLine();

        Console.WriteLine("\nКонтакт 3:");
        
        Console.WriteLine("Введите имя:");
        names3 = Console.ReadLine();
       
        Console.WriteLine("Введите телефонный номер:");
        phoneNumbers3 = Console.ReadLine();

        Console.WriteLine("\nСохраненные контакты:");
        Console.WriteLine($"Имя: {names1}, Телефон: {phoneNumbers1}");
        Console.WriteLine($"Имя: {names2}, Телефон: {phoneNumbers2}");
        Console.WriteLine($"Имя: {names3}, Телефон: {phoneNumbers3}");
    
    }
}
