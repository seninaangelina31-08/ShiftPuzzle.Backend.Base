using System;
using System.IO;
using System.Text;
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

[System.Serializable] public class Book
{
    // поля класса
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }

    public Book() { } // Пустой конструктор для десериализации

    // конструктор класса
    public Book(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
    }
}

[System.Serializable] public class Library
{
    // поля класса
    public string libraryName { get; set; }
    public List<Book> books { get; set; }

    public Library() { } // Пустой конструктор для десериализации

    // конструктор класса
    public Library(string libraryName, List<Book> books)
    {
        this.libraryName = libraryName;
        this.books = books;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Practic A
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

        // Practic B

        order_anna.totalPrice = Convert.ToInt32((order_anna.totalPrice + 1550) * 0.98);
        order_anna.items.Add("Салфетки для монитора");

        string json = JsonSerializer.Serialize(order_anna);
        path = "2_new.json";
        File.WriteAllText(path, json, Encoding.UTF8);

        path = "5.json";
        string jsonFromFile3 = File.ReadAllText(path);
        Library library = JsonSerializer.Deserialize<Library>(jsonFromFile3);

        library.books.Add(new Book { title = "Капитанская дочка", author = "Александр Пушкин", year = 1836});

        string json2 = JsonSerializer.Serialize(library);
        path = "5_new.json";
        File.WriteAllText(path, json2, Encoding.UTF8);
    }
}
