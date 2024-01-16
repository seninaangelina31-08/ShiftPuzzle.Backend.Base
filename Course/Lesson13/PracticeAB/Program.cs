namespace PracticeAB;
using System.Collections.Generic; // библиотека для работы с List и Dictionary
using System.Text.Json; // библиотека для работы с JSON

// объявление сериализуемого класса People
[System.Serializable] public class People
{
    // поля класса
    public int id { get; set; }
    public string Name { get; set; }
    public string email { get; set; }
    public bool isVerified { get; set; }

    public People() { } // Пустой конструктор для десериализации

    // конструктор класса
    public People(string a, int b, string c, bool d)
    {
        this.id=b;
        this.Name = a;
        this.email=c;
        this.isVerified=d;
    }
}
[System.Serializable] public class Check
{
    // поля класса
    public string orderId { get; set; }
    public string customerName { get; set; }
    public int totalPrice { get; set; }
    public List<string> items { get; set; }

    public Check() { } // Пустой конструктор для десериализации
}
class Program
{
    static void Main(string[] args)
    {
        const string path = "1.json";
        string jsonFromFile = File.ReadAllText(path);
        People read_people = JsonSerializer.Deserialize<People>(jsonFromFile);
        if (read_people != null)
        {
            Console.WriteLine($"Айди: {read_people.id}\nПочта: {read_people.email}");
        }
        Console.WriteLine("-----------------");
        const string path2 = "2.json";
        string jsonFromFile2 = File.ReadAllText(path2);
        Check read_Check = JsonSerializer.Deserialize<Check>(jsonFromFile2);
        if (read_Check != null)
        {
            Console.WriteLine($"Скидка: {read_Check.totalPrice/10*9}");

            // вывод содержимого списка ссылок
            Console.WriteLine("Список покупок:");
            foreach (string el in read_Check.items)
            {
                Console.Write(el+" ");
            }
        }
    }
}
