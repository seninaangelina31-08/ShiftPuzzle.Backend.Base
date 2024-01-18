using System;
using System.Text.Json;

namespace PracticeAB;

[System.Serializable] public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public bool isVerified { get; set; }

    public User() {}
    public User(int id, string name, string email, bool is_verified)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.isVerified = is_verified;
    }


}

[System.Serializable] public class Order
{
    public string orderId { get; set; }
    public string customerName { get; set; }
    public double totalPrice { get; set; }
    public List<string> items { get; set; }
    
    public Order(){}

    public Order(string order_id, string customer_name, int total_price, List<string> items)
    {
        this.orderId = order_id;
        this.customerName = customer_name;
        this.totalPrice = total_price;
        this.items = items;
    }
}
[System.Serializable] public class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }
    public Book(){}
    public Book(string title, string author, string year)
    {
        this.title = title;
        this.author = author;
        this.year = Convert.ToInt32(year);
    }
}
[System.Serializable] public class Library
{
    public string libraryName { get; set; }
    public List<Book> books { get; set; }
    public Library(){}
    public Library(string l_name, List<Book> books)
    {
        this.libraryName = l_name;
        this.books = books;
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        string path = "1.json";
        string read_file = File.ReadAllText(path);
        User client_001 = JsonSerializer.Deserialize<User>(read_file);
        Console.WriteLine($"Email: {client_001.email}\nID: {client_001.id}\n");

        path = "2.json";
        read_file = File.ReadAllText(path);
        Order order_1 = JsonSerializer.Deserialize<Order>(read_file);
        Console.WriteLine($"Список товаров: ");
        foreach (var el in order_1.items)
        {
            Console.WriteLine($"-{el}");
        }
        Console.WriteLine($"Сумма без скидки: {order_1.totalPrice}\nСумма со скидкой: {order_1.totalPrice * 0.9}");

        path = "4.json";
        read_file = File.ReadAllText(path);
        Order order_2 = JsonSerializer.Deserialize<Order>(read_file);
        order_2.items.Add("Салфетки для монитора");
        order_2.totalPrice = (order_2.totalPrice + 1550) * 0.98;
        string write_json = JsonSerializer.Serialize(order_2);
        File.WriteAllText("4_solve.json", write_json);

        path = "5.json";
        read_file = File.ReadAllText(path);
        
        Library lib_1 = JsonSerializer.Deserialize<Library>(read_file);
        lib_1.books.Add(new Book("Капитанская дочка", "Александр Пушкин", "1836"));
        write_json = JsonSerializer.Serialize(lib_1);
        File.WriteAllText("5_solve.json", write_json);
    }
}
