using System;
using System.Collections.Generic; // библиотека для работы с List и Dictionary
using System.Text.Json;
using practiceab; // библиотека для работы с JSON

namespace practiceab;


[System.Serializable] public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public bool IsVerified { get; set; }

    public User() { }

    public User(int id, string name, string email, bool isVerified)
    {
        this.Id = id; 
        this.Name = name;
        this.Email = email;
        this.IsVerified = isVerified;
    }
}


[System.Serializable] public class Order 
{
    public string orderId { get; set; }
    public string customerName { get; set; }
    public int totalPrice { get; set; }
    public List<string> items { get; set; }
    
    public Order() { }
    
    public Order(string orderId, string customerName, int totalPrice, List<string> items)
    {
        this.orderId = orderId; 
        this.customerName = customerName;
        this.totalPrice = totalPrice;
        this.items = items;
    }
    public void Add_product(string item, int price_product)
    {
        items.Add(item);
        totalPrice += price_product;
    }
}

[System.Serializable] public class Books
{
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }
    
    public Books() {}

    public Books(string Title, string Author, int Year)
    {
        this.title = Title;
        this.author = Author;
        this.year = Year;
    }
}

[System.Serializable] public class Library
{
    public string libraryName { get; set; }
    public List<Books> books { get; set; }

    public Library() {}

    public Library(string LibraryName, List<Books> Books)
    {
        this.libraryName = LibraryName;
        this.books = Books;
    }

    public void Add_book(Books book)
    {
        books.Add(book);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Practice A 
        Console.WriteLine("Task1");
        const string path = "1.json";
        string jsonFromFile = File.ReadAllText(path);
        User user1 = JsonSerializer.Deserialize<User>(jsonFromFile);
        Console.WriteLine($"Id: {user1.Id}\nEmail: {user1.Email}\n");


        Console.WriteLine("Task2");
        const string path2 = "2.json";
        string jsonFromFile1 = File.ReadAllText(path2);
        Order order1 = JsonSerializer.Deserialize<Order>(jsonFromFile1);
        foreach (string prod in order1.items)
        {
            Console.WriteLine(prod);
        }
        order1.totalPrice = Convert.ToInt32(order1.totalPrice * 0.9);
        Console.WriteLine(order1.totalPrice);
        Console.WriteLine();

        // Practice B
        Console.WriteLine("Task4");
        order1.Add_product("Салфетки для монитора", 1550);
        order1.totalPrice = Convert.ToInt32(order1.totalPrice * 0.98);
        Console.WriteLine($"Цена с учетом скидки: {order1.totalPrice}");

        string json = JsonSerializer.Serialize(order1);
        const string path4 = "4.json";
        File.WriteAllText(path4, json);
        Console.WriteLine();

        Console.WriteLine("Task5");
        const string path5 = "5.json";
        string jsonFromFile5 = File.ReadAllText(path5);
        Library lib = JsonSerializer.Deserialize<Library>(jsonFromFile5);
        Console.WriteLine(lib.libraryName);
        Books book1 = new Books("Дубровский", "Александр Пушкин", 1841);
        lib.Add_book(book1);

        string json1 = JsonSerializer.Serialize(lib);
        File.WriteAllText(path5, json1);
    }
}

