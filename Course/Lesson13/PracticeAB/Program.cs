using System;
using System.Collections.Generic; // библиотека для работы с List и Dictionary
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json; // библиотека для работы с JSON
using System.Text.Unicode;


namespace PracticeAB;

// объявление сериализуемого класса Product
[System.Serializable] public class User
{
    // поля класса
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool IsVerified { get; set; }

    public User() { } // Пустой конструктор для десериализации

    // конструктор класса
    public User(int id, string name, string email, bool isVerified)
    {
        this.Id = id;
        this.Name = name;
        this.Email = email;
        this.IsVerified = isVerified;
    }
}

[System.Serializable] public class Customer 
{
    public string orderId { get; set; }
    public string customerName { get; set; }
    public float totalPrice { get; set; }
    public List<string> items { get; set; }

    public Customer() { }

    public Customer(string orderIdObj, string customerNameObj, float totalPriceObj, List<string> itemsObj)
    {
        this.orderId = orderIdObj;
        this.customerName = customerNameObj;
        this.totalPrice = totalPriceObj;
        this.items = itemsObj;
    }

    public void MakeDiscount(int discount)
    {
        this.totalPrice *= (float)(1 - (discount * 0.01));
    }

    public void AddPrice(int price)
    {
        this.totalPrice += price;
    }

    public void AddItem(string item)
    {
        this.items.Add(item);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var options1 = new JsonSerializerOptions {Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic), WriteIndented = true};

        // // Сериализация в JSON
        // string json = JsonSerializer.Serialize(ivan);
        // Console.WriteLine(json); // вывод сериализованного объекта в консоль

        const string IvanInfo = "1.json";
        const string AnnaInfo = "2.json";

        // File.WriteAllText(path, json); // запись объекта в JSON файл

        // Десериализация из JSON
        string jsonFromFile = File.ReadAllText(IvanInfo);
        User? ivan = JsonSerializer.Deserialize<User>(jsonFromFile);
        
        if (ivan != null)
        {
            // вывод полей объекта
            Console.WriteLine($"Пользователь {ivan.Name}\nEmail: {ivan.Email}\nID: {ivan.Id}\n");

        }

        // Часть вторая Практика A

        jsonFromFile = File.ReadAllText(AnnaInfo);
        Customer? anna = JsonSerializer.Deserialize<Customer>(jsonFromFile);

        if (anna != null)
        {
            // вывод полей объекта
            Console.WriteLine($"Анна петрова купила: ");
            foreach (var good in anna.items)
            {
                Console.WriteLine(good);
            }

            Console.WriteLine($"Цена до скидки = {anna.totalPrice}");
            anna.MakeDiscount(10);
            Console.WriteLine($"Цена после скидки = {anna.totalPrice}");

            Console.WriteLine();

            // Часть Б

            anna.AddItem("Салфетки для монитора");
            anna.AddPrice(1550);
            anna.MakeDiscount(2);
            anna.AddItem("Книга Пушкина: Евгений Онегин");
            anna.AddPrice(1400);

            Console.WriteLine($"Анна петрова купила: ");
            foreach (var good in anna.items)
            {
                Console.WriteLine(good);
            }

            // Сериализация в JSON
            string json = JsonSerializer.Serialize(anna, options1);
            Console.WriteLine(json); // вывод сериализованного объекта в консоль
            File.WriteAllText("PartB_L13.json", json);


        }
    }
}
