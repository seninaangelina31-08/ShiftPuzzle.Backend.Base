using System;
//using System.Collections.Generatic;
using System.Text.Json;
using System.IO;

namespace PracticeAB;

[System.Serializable]class User
{
public string name { get; set; } 
public int id { get; set; }
public string email { get; set; }

public User() {}
public User(string name, int id, string email, List<string> inf)
    {
        this.id = id;
        this.name = name;
        this.email = email;
    }
}

[System.Serializable]class Order
{

    public string customerName { get; set; }
    public int totalPrice { get; set; }
    public List<string> items { get; set; }

    public Order() {}

public Order(string customerName, int totalPrice, List<string> items)
    {
        this.customerName = customerName;
        this.totalPrice = totalPrice;
        this.items = items;
    } 
}

[System.Serializable]public class Book
{
    public string title { get; set; } 
    public string author { get; set; }
    public int year { get; set; }

public Book() {}

public Book( string title, string author, int year)
{
    this.title = title; 
    this.author = author;
    this.year = year;
}

}

[System.Serializable]public class Library
{
    public string libraryName { get; set; }
    public List<Book> books { get; set; }

    public Library() {}

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
    const string path = "1.json";
    string infa = File.ReadAllText(path);
    User pirat = JsonSerializer.Deserialize<User>(infa);

    const string path1 = "2.json";
    string infa1 = File.ReadAllText(path1);;
    Order pirat1 = JsonSerializer.Deserialize<Order>(infa1);
    
    const string path2 = "4.json";
    string infa2 = File.ReadAllText(path2);
    Order pirat2 = JsonSerializer.Deserialize<Order>(infa2);

    const string path3 = "5.json";
    string infa3 = File.ReadAllText(path3);
    Library pirat3 = JsonSerializer.Deserialize<Library>(infa3);

    Console.WriteLine($"User name:{pirat.name} ID: {pirat.id} Email: {pirat.email}");
    Console.Write($"User name:{pirat1.customerName} \nPrice with sale 10%: {pirat1.totalPrice * 0.90} Purchases:");
    foreach( var i in pirat1.items)
    {  
        Console.Write($"\n{i}");
    }


if (pirat2 != null)
{
    const string salfetki = "салфетки для монитора";
    pirat2.items.Add(salfetki);
    pirat2.totalPrice += 1550;
    pirat2.totalPrice -= pirat2.totalPrice * 1000 / 100 * 2 / 1000;
    string json2 = JsonSerializer.Serialize(pirat2);
    File.WriteAllText(path2, json2);
    Console.WriteLine("\nItem was added!");
}

if (pirat3 != null)
{
Book pushkin = new Book("Песнь о вещем Олеге","Александр Пушкин", 1822);
pirat3.books.Add(pushkin);
string json3 = JsonSerializer.Serialize(pirat3);
File.WriteAllText(path3, json3);
Console.WriteLine("\nItem was added!");

}

    }
}
