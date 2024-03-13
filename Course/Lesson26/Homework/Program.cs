namespace homework;
using System.Collections.Generic;


public class Order
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Order(string name, int price)
    {
        Name = name;
        Price = price;
    }
}


public class User
{
    public event Action <string> OnNewOrder;
    public event Action <string> OnOrderDelivered;
    public event Action <string, int> OnNewOrderWithBonus;
    public string Name { get; set; }
    public int Balance { get; set; }
    public int Bonus { get; set; }
    public List<Order> Orders { get; set; }

    public User(string name, int balance, int bonus, List<Order> orders)
    {
        Name = name;
        Balance = balance;
        Bonus = bonus;
        Orders = orders;
        OnNewOrder += SendNotificationNewOrder;
        OnOrderDelivered += SendNotificationOrderDelivered;
        OnNewOrderWithBonus += SendNotificationNewOrderWithBonus;
    }

    public static void SendNotificationNewOrder(string name)
    {
        Console.WriteLine($"Новый заказ - {name}");
    }

    public static void SendNotificationOrderDelivered(string name)
    {
        Console.WriteLine($"Заказ {name} доставлен");
    }

    public static void SendNotificationNewOrderWithBonus(string name, int bonus)
    {
        Console.WriteLine($"Списание бонусов ({bonus})");
        Console.WriteLine($"Новый заказ - {name}");
    }

    public void NewOrder(Order order)
    {
        Balance -= order.Price;
        Bonus += Convert.ToInt32(0.05 * order.Price);
        Orders.Add(order);
        OnNewOrder?.Invoke(order.Name);
    }

    public void GetOrder(Order order)
    {
        Orders.Remove(order);
        OnOrderDelivered?.Invoke(order.Name);
    }

    public void NewOrderWithBonus(int bonus, Order order)
    {
        if (Bonus > bonus)
        {
            Bonus -= bonus;
            Balance -= (order.Price - bonus);
            OnNewOrderWithBonus?.Invoke(order.Name, bonus);
        }
        else
        {
            Console.WriteLine("Недостаточно бонусов");
        }
    }

    public void ReplenishBalanc(int summa)
    {
        Balance += summa;
    }
}


class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        User user1 = new User("Ilya", 1000, 100, orders);
        Order order1 = new Order("Peperoni", 500);
        user1.NewOrder(order1);
        user1.GetOrder(order1);
        Order order2 = new Order("Margarita", 250);
        user1.NewOrderWithBonus(100, order2);
        user1.GetOrder(order2);
    }
}
