/*
Пратика А:
Система уведомлений:
Создайте простую систему уведомлений, где пользователь может подписываться на различные события (например, "новое сообщение", "новый заказ" и т. д.) и получать уведомления при их возникновении.

 
Пратика Б:

Система обработки асинхронных событий в предыдщуем примере:
Создайте систему обработки асинхронных событий, где различные задачи выполняются параллельно. Реализуйте механизм подписки на события с возможностью асинхронного выполнения обработчиков событий.
*/

// система уведомлений  
using System;   
using System.Collections.Generic;



public  class NotificationSystem
{
    public event Action <string> OnNewMessage;
    public event Action <string> OnNewOrder; 
    public event Action <string, string> OnDeliveredOrder; 
        
    public NotificationSystem()
    { 

    }
// данная обертка нужна для того чтобы вызвать событие, 
//т.к. напрямую вызвать событие нельзя изза того что  фукнция мейн в статическом классе
    public void NewMessage(string message)
    {
        OnNewMessage?.Invoke(message);
    }
    public void NewOrder(string orderInfo) 
    {
        OnNewOrder?.Invoke(orderInfo);
    }

    public void NewDeliveredOrder(string order, string dateTime)
    {
        OnDeliveredOrder?.Invoke(order, dateTime);
    }
}

public class Program
{
    static void Main()
    {
        NotificationSystem notificationSystem = new NotificationSystem();
        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOrder;
        notificationSystem.OnDeliveredOrder += TestDeliveredOrder;

        Console.WriteLine("Input message: ");
        string messageForUser = Console.ReadLine();
        Console.WriteLine("Input product info: ");
        string orderInfo = Console.ReadLine();
        string order = orderInfo;
        string dateTime = "28.02.24 17:00";

        notificationSystem.NewMessage(messageForUser);
        notificationSystem.NewOrder(orderInfo);
        notificationSystem.NewDeliveredOrder(order, dateTime);
    }
    
    public static async void TestNewMsg(string message)
    {
       await TestNewMsgAsync(message);
    }
    public static async void TestNewOrder(string orderInfo)
    {
        await TestNewOrderAsync(orderInfo);
    }

    public static async void TestDeliveredOrder(string order, string dateTime)
    {
        await TestOrderDeliveredAsync(order, dateTime);
    }



    public static async Task TestNewMsgAsync(string message)
    {
        Console.WriteLine($"New message: {message}");
    }

    public static async Task TestNewOrderAsync(string orderInfo)
    {
        Console.WriteLine($"New order: {orderInfo}");
    }

    public static async Task TestOrderDeliveredAsync(string order, string dateTime)
    {
        Console.WriteLine($"Order '{order}' delivered async. At time {dateTime}");
    }
   
}   