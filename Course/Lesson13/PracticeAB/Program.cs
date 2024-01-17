namespace PracticeAB;
using System;
using System.Collections.Generic;
using System.Text.Json;


class Program
{
    static void Main(string[] args)
    {

        // Задание 1
        const string path1 = "1.json";

        string JsonFromFile1 = File.ReadAllText(path1);
        User Person1 = JsonSerializer.Deserialize<User>(JsonFromFile1);

        if (Person1 is not null)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine($"Почта = {Person1.email}; Id = {Person1.id}\n\n");
        }

        // Задание 2
        const string path2 = "2.json";
        string JsonFromFile2 = File.ReadAllText(path2);
        Customer Person2 = JsonSerializer.Deserialize<Customer>(JsonFromFile2);

        if (Person2 is not null)
        {
            Console.WriteLine("Задание 2");
            Console.WriteLine($"Цена = {Person2.totalPrice * 9/10}");

            Console.WriteLine("Товары:");
            foreach (var item in Person2.items)
            {
                Console.WriteLine(item);
            }
        }

        // Задание 3(4)

        const string path4 = "4.json";
        string JsonFromFile4 = File.ReadAllText(path4);

        Customer Person4 = JsonSerializer.Deserialize<Customer>(JsonFromFile4);
        // Console.WriteLine(Person4);
        // Person4.items.Add("Napkins for monitor");
        // Person4.totalPrice = (5200 + 1200)*98/100;

        // string json4 = JsonSerializer.Serialize(Person4);
        // File.WriteAllText(path4, json4);

        Console.WriteLine("\n\nЗадание 4");
        Console.WriteLine($"Цена: {Person4.totalPrice}");
        Console.WriteLine("Товары:");
        foreach (var item in Person4.items)
        {
            Console.WriteLine(item);
        }
        // Console.WriteLine(json4);

        // Задание 4(5)

        const string path5 = "5.json";
        string JsonFromFile5 = File.ReadAllText(path5);

        Book PushkinBook = new Book("Eugene Onegin", "Alexander Pushkin", 1833);

        Library Sphere = JsonSerializer.Deserialize<Library>(JsonFromFile5);
        // Sphere.books.Add(PushkinBook);

        // string json5 = JsonSerializer.Serialize(Sphere);
        // File.WriteAllText(path5, json5);

        Console.WriteLine("\n\nЗадание 5");
        Console.WriteLine("Книги:");
        foreach (var item in Sphere.books)
        {
            Console.WriteLine($"\nКнига: {item.title}");
            Console.WriteLine($"Автор: {item.author}");
            Console.WriteLine($"Год: {item.year}");
        }
    }

}

[System.Serializable] public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public bool isVerified { get; set; }

    public User() {}

    public User(int Id, string Name, string Email, bool IsVerified){
        this.id = Id;
        this.name = Name;
        this.email = Email;
        this.isVerified = IsVerified;
    }

}


[System.Serializable] public class Customer
{

    public string orderId { get; set; }
    public string customerName { get; set; }
    public int totalPrice { get; set; }
    public List<string> items { get; set; }

    public Customer() {}

    public Customer(string OrderId, string CustomerName, int TotalPrice, List<string> Items){
        this.orderId = OrderId;
        this.customerName = CustomerName;
        this.totalPrice = TotalPrice;
        this.items = Items;
    }
}

[System.Serializable] public class Book
{

    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }

    public Book() {}

    public Book(string Title, string Author, int Year)
    {
        this.title = Title;
        this.author = Author;
        this.year = Year;
    }
}

[System.Serializable] public class Library
{
    public string libraryName { get; set; }
    public List<Book> books { get; set; }

    public Library() {}

    public Library(string LibraryName, List<Book> Books)
    {
        this.libraryName = LibraryName;
        this.books = Books;
    }
}