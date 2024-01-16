using System;
using System.Collections.Generic; // библиотека для работы с List и Dictionary
using System.Text.Json; // библиотека для работы с JSON

namespace PracticeAB;

[System.Serializable] public class User
{
    // поля класса
    public string name { get; set; }
    public string email { get; set; }
    public int id { get; set; }
    public bool isVerified { get; set; }

    public User() { } // Пустой конструктор для десериализации

    // конструктор класса
    public User(int id, string name, string email, bool isVerified)
    {
        this.name = name;
        this.email = email;
        this.id = id;
        this.isVerified = isVerified;
    }
}

[System.Serializable] public class Order
{
    // поля класса
    public string orderId { get; set; }
    public string customerName { get; set; }
    public int totalPrice { get; set; }
    public List<string> items { get; set; }

    public Order() { } // Пустой конструктор для десериализации

    // конструктор класса
    public Order(string orderId, string customerName, int totalPrice, List<string> items)
    {
        this.orderId = orderId;
        this.customerName = customerName;
        this.totalPrice = totalPrice;
        this.items = items;
    }
}

class Program
{
    static void Main(string[] args)
    {
        string path = "1.json";
        string jsonFromFile = File.ReadAllText(path);
        User ivan = JsonSerializer.Deserialize<User>(jsonFromFile);

        if (ivan != null)
        {
            // вывод полей объекта
            Console.WriteLine($"ID: {ivan.id}\nEmail: {ivan.email}\n\n");
        }

        path = "2.json";
        string jsonFromFile2 = File.ReadAllText(path);
        Order order_anna = JsonSerializer.Deserialize<Order>(jsonFromFile2);

        if (order_anna != null)
        {
            // вывод полей объекта
            Console.WriteLine($"Name: {order_anna.customerName}\nPrice: {order_anna.totalPrice * 0.9}\nItems:");

            foreach (var item in order_anna.items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
