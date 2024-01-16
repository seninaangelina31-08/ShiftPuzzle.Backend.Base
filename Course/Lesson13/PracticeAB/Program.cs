using System;
using System.Collections.Generic;
using System.Text.Json;

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
    public string orderID {get; set;}
    public string customerName {get; set;}
    public int totalPrice {get; set;}
    public List<string> items {get; set;}

    public Orders() {}

    public Orders(string OrderID, string CustomerName, int TotalPrice, List<string> Items)
    {
        this.orderID = OrderID;
        this.customerName = CustomerName;
        this.totalPrice = TotalPrice;
        this.items = Items;
    }
}
class Program
{
    static void Main(string[] args)
    {
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
    }
}
