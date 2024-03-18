namespace PizzaDelivery;

using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;

[System.Serializable]
public class Order
{
    public int OrderId { get; set; }
    public string Product { get; set; }
    public double Price { get; set; }
    public string CreateDate { get; set; }

    public Order() { }

    public Order(int orderId, string product, double price, string createDate)
    {
        OrderId = orderId;
        Product = product;
        Price = price;
        CreateDate = createDate;
    }
}


public class Notifications
{
    public event Action<Order> OnCreateOrder;
    public event Action<int> OnDeleteOrder;
    public event Action<int, string> OnUpdateOrder;

    public event Action OnFifthOrder;

    string path = "Database.json";


    public bool isFifthOrder()
    {
        string jsonFromFile = File.ReadAllText(path);
        List<Order> orderList = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);
        if (orderList.Count % 4 == 0)
        {
            OnFifthOrder?.Invoke();
            return true;
        }
        return false;
    }
    public void CreateOrder(Order order)
    {
        string jsonFromFile = File.ReadAllText(path);
        List<Order> orderList = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);

        orderList.Add(order);

        var options1 = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };

        if (isFifthOrder())
        {
            orderList[^1].Price = orderList[^1].Price * 0.5;
            OnFifthOrder?.Invoke();
        }

        string json = JsonSerializer.Serialize(orderList, options1);
        System.IO.File.WriteAllText(path, json);

        OnCreateOrder?.Invoke(order);
    }

    public void DeleteOrder(int id)
    {
        string jsonFromFile = File.ReadAllText(path);
        List<Order> orderList = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);
        Order deleteOrder = new Order();

        foreach(var order in orderList)
        {
            if (order.OrderId == id)
            {
                deleteOrder = order;
            }
        }



        if (deleteOrder.OrderId == 0)
        {
            Console.WriteLine("Заказ не найден");
        }
        else
        {
            orderList.Remove(deleteOrder);
            
            var options1 = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(orderList, options1);
            System.IO.File.WriteAllText(path, json);
            
            OnDeleteOrder?.Invoke(id);    
        }
    }

    public void UpdateOrder(int id, string newDate)
    {
        string jsonFromFile = File.ReadAllText(path);
        List<Order> orderList = JsonSerializer.Deserialize<List<Order>>(jsonFromFile);
        Order updatingOrder = new Order();

        foreach(var order in orderList)
        {
            if (order.OrderId == id)
            {
                updatingOrder = order;
                updatingOrder.CreateDate = newDate;
            }
        }



        if (updatingOrder.OrderId == 0)
        {
            Console.WriteLine("Заказ не найден");
        }
        else
        {
            var options1 = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(orderList, options1);
            System.IO.File.WriteAllText(path, json);
            
            OnUpdateOrder?.Invoke(id, newDate);    
        }
        

    }

}

class Program
{
    static void Main(string[] args)
    {
        Notifications notifications = new Notifications();
        notifications.OnCreateOrder += TestCreateOrder;
        notifications.OnDeleteOrder += TestDeleteOrder;
        notifications.OnUpdateOrder += TestUpdateOrder;
        notifications.OnFifthOrder += TestFifthOrder;


        while (true)
        {
            Console.WriteLine("Выберите опцию");
            Console.WriteLine("1: Создать заказ\n2: Удалить заказ\n3: Изменить время заказа\n4: Выйти");
            int change = Convert.ToInt32(Console.ReadLine());

            switch (change)
            {
                case (1):

                    Console.WriteLine("Введите id");
                    int id = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите продукт");
                    string product = Console.ReadLine();

                    Console.WriteLine("Введите цену");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите время создания");
                    string date = Console.ReadLine();

                    Order order = new Order(id, product, price, date);
                    notifications.CreateOrder(order);
                    Console.WriteLine("________________");
                    break;

                case (2):

                    Console.WriteLine("Введите id");
                    int Orderid = Convert.ToInt32(Console.ReadLine());

                    notifications.DeleteOrder(Orderid);
                    Console.WriteLine("________________");
                    break;

                case (3):

                    Console.WriteLine("Введите id");
                    int UpdatingId = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите новое время");
                    string NewDate = Console.ReadLine();

                    notifications.UpdateOrder(UpdatingId, NewDate);
                    Console.WriteLine("________________");
                    break;

                case (4):

                    Console.WriteLine("________________");
                    return;
            }
        }
    }

    public static void TestCreateOrder(Order order)
    {
        Console.WriteLine($"Добавлен новый заказ: {order.Product}");
    }

    public static void TestDeleteOrder(int id)
    {
        Console.WriteLine($"Заказ {id} удален");
    }

    public static void TestUpdateOrder(int id, string newDate)
    {
        Console.WriteLine($"Время заказа {id} изменено на {newDate}");
    }

    public static void TestFifthOrder()
    {
        Console.WriteLine("Снижена цена за 5 заказ по программе лояльности");
    }
}

