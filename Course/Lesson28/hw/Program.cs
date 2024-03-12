using System;   
using System.Collections.Generic;


public  class NotificationSystem
{
    public event Action <string> OnNewOrder;
    public event Action <int> OnTips; 
    public event Action <string, string> OnDelivered; 
        
    public NotificationSystem()
    { 

    }

    public void NewOrder(string order) 
    {
        OnNewOrder?.Invoke(order);
    }

    public void Tips(int sum)
    {
        OnTips?.Invoke(sum);
    }

    public void Delivered(string order, string dateTime) 
    {
        OnDelivered?.Invoke(order, dateTime);
    }
}

public class Program
{
    static void Main()
    {
        NotificationSystem notificationSystem = new NotificationSystem();
        notificationSystem.OnNewOrder += TestNewOreder;
        notificationSystem.OnTips += TestTips;
        notificationSystem.OnDelivered += TestDelivered;

        notificationSystem.NewOrder("New Order");
        notificationSystem.Tips(12);
        notificationSystem.Delivered("Delivery was done", "30.02.2024");
 
        
    }

    public static async void TestNewOreder(string order)
    {
        await TestNewOrederAsync(order);
    }

    public static async void TestTips(int sum)
    {
       await TestTipsAsync(sum);
    }

    public static async void TestDelivered(string order, string dateTime)
    {
        await TestDeliveredAsync(order, dateTime);
    }


    public static async Task TestNewOrederAsync(string order)
    {
        Console.WriteLine($"New order async: {order}");
    }

    public static async Task TestTipsAsync(int sum)
    {
        if (sum<10000){
            Console.WriteLine("Sing");
        }
        else{
            Console.WriteLine("Sing and dance");
        }

    }

    public static async Task TestDeliveredAsync(string order, string dateTime)
    {
        Console.WriteLine($"Order '{order}' delivered async. At time {dateTime}");
    }
   
}   
