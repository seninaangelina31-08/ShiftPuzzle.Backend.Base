using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace PracticeAB;

[System.Serializable] public class Users
{
    public int id {get; set;}
    public string name {get; set;}
    public string email {get; set;}
    public bool isVerified {get; set;}

    public Users() {}

    public Users(int Id, string Name, string Email, bool IsVerified)
    {
        this.id = Id;
        this.name = Name;
        this.email = Email;
        this.isVerified = IsVerified;
    }
}

[System.Serializable] public class Orders
{
    public string orderId {get; set;}
    public string customerName {get; set;}
    public int totalPrice {get; set;}
    public List<string> items {get; set;}

    public Orders() {}

    public Orders(string OrderId, string CustomerName, int TotalPrice, List<string> Items)
    {
        this.orderId = OrderId;
        this.customerName = CustomerName;
        this.totalPrice = TotalPrice;
        this.items = Items;
    }
}

public class Books
{
    public string title {get; set;}
    public string author  {get; set;}
    public int year {get; set;}

    public Books(string Title, string Author, int Year)
    {
        this.title = Title;
        this.author = Author;
        this.year = Year;
    }
}
[System.Serializable] public class Libraries
{
    public string libraryName {get; set;}
    public List<Books> books {get; set;}

    public Libraries() { }
    
    public Libraries(string LibraryName, List<Books> Books)
    {
        this.libraryName = LibraryName;
        this.books = Books;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var options1 = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };
        string jsonFromFile = File.ReadAllText("1.json");
        Users user = JsonSerializer.Deserialize<Users>(jsonFromFile);
        if (user != null)
        {
            if (user.name == "Иван Иванов")
                Console.WriteLine($"Пользователь {user.name}:\nПочта: {user.email}\nID: {user.id}");
        }

        Console.WriteLine();

        jsonFromFile = File.ReadAllText("2.json");
        Orders order = JsonSerializer.Deserialize<Orders>(jsonFromFile);
        if (order != null)
        {
            if (order.customerName == "Анна Петрова")
            {
                Console.WriteLine($"{order.customerName} купила:");
                foreach (string item in order.items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"на сумму {order.totalPrice}\nИтого к оплате со скидкой 10%: {order.totalPrice - order.totalPrice*10/100}");
            }
        }

        Console.WriteLine();

        order.items.Add("Салфетки для монитора");
        order.totalPrice += 1550;
        order.totalPrice -= order.totalPrice * 2 / 100;
        string json = JsonSerializer.Serialize(order, options1);
        Console.WriteLine(json);
        File.WriteAllText("4.json", json);

        Console.WriteLine();

        jsonFromFile = File.ReadAllText("5.json");
        Libraries library = JsonSerializer.Deserialize<Libraries>(jsonFromFile);
        if (library != null)
        {
            Console.WriteLine($"{library.libraryName}");
            foreach(Books book in library.books)
            {
                Console.WriteLine($"{book.title} {book.author} {book.year}");
            }
        }
        Books new_book = new Books("Капитанская дочка", "Александр Пушкин", 1836);
        library.books.Add(new_book);
        json = JsonSerializer.Serialize(library, options1);
        Console.WriteLine(json);
        File.WriteAllText("5.json", json);
    }
}
