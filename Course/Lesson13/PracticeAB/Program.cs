using System;
using System.Collections.Generic;
using System.Text.Json;
using System.IO;

[System.Serializable] public class Ivan
{
    public int Id{ get; set; }
    public string Name{ get; set; }
    public string Email{ get; set; }
    public bool IsVerified{ get; set; }

    public Ivan() {}

    public Ivan(int id, string name, string email, bool isVerified)
    {
        this.Id = id;
        this.Name = name;
        this.Email = email;
        this.IsVerified = isVerified;
    }
}
public class Anna
{
    
    public string OrderId{ get; set; }
    public string CustomerName{ get; set; }
    public double TotalPrice{ get; set; }
    public List<string> Items { get; set; }

    public Anna() {}

    public Anna(string orderId, string customerName, double totalPrice, List<string> items)
    {
        this.OrderId = orderId;
        this.CustomerName = customerName;
        this.TotalPrice = totalPrice;
        this.Items = items;
    }
}
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book() {}

    public Book(string title, string author, int year)
    {
        this.Title = title;
        this.Author = author;
        this.Year = year;
    }
}

public class Library
{
    public string LibraryName { get; set; }
    public List<Book> Books { get; set; }

    public Library() {}

    public Library(string libraryName, List<Book> books)
    {
        this.LibraryName = libraryName;
        this.Books = books;
    }
}
class Programm
{
    static void Main(string[] args){
        //1
        Ivan ivan = new Ivan(12345, "Иван Иванов", "ivanov@example.com", true);
        string json1 = JsonSerializer.Serialize(ivan);
        string jsonIDivan = File.ReadAllText("1.json");
        if (ivan != null)
        {
            System.Console.WriteLine($"id: {ivan.Id}");
        }
        //2
        List<string> items = new List<string>{"Ноутбук", "Мышь"};
        Anna anna = new Anna("ORD10245", "Анна Петрова", 5600, items);
        string json2 = JsonSerializer.Serialize(anna);
        string jsonPriceAnna = File.ReadAllText("2.json");
        if (anna != null)
        {
            System.Console.WriteLine($"totalPrice {anna.TotalPrice*0.9}");
            
        }
        //4
        items.Add("Салфетки для мониторов");
        anna.Items = items;
        anna.TotalPrice = 7150;
        string json3 = JsonSerializer.Serialize(anna);
        File.WriteAllText("4.json", json3);
        string jsonPrice2Anna = File.ReadAllText("4.json");
        if (anna != null)
        {
            System.Console.WriteLine($"totalPrice2: {anna.TotalPrice*0.98}");
        }
        //5
        Book book1 = new Book("Война и мир", "Лев Толстой", 1869);
        Book book2 = new Book("Мастер и Маргарита", "Михаил Булгаков", 1967);
        Book book3 = new Book("Евгений Онегин", "Александр Пушкин", 1833);
        List<Book> books = new List<Book>();
        books.Add(book1);
        books.Add(book2);
        books.Add(book3);
        Library lyb = new Library("Городская библиотека", books);
        string json5 = JsonSerializer.Serialize(lyb);
        File.WriteAllText("5.json", json5);
        /*
        if (lyb != null)
        {
            System.Console.WriteLine($"lybname {lyb.LibraryName}");
            foreach (var book in books)
            {
                System.Console.WriteLine(book);
            }
        }
        */

    }
    
}