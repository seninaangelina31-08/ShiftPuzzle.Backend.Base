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
using System.Threading.Tasks;


public  class NotificationSystem
{
    public event Action<string> OnNewMessage;
    public event Action<string> OnNewOrder;
    public event Action<string, string> OnNewDeliver;
    public NotificationSystem()
    { 

    }
// данная обертка нужна для того чтобы вызвать событие, 
//т.к. напрямую вызвать событие нельзя изза того что  фукнция мейн в статическом классе
    public void NewMessage(string message)
    {
        OnNewMessage?.Invoke(message);
    }
    public void NewOrder(string order) 
    {
        OnNewOrder?.Invoke(order);
    }
    public void NewDelivered(string order, string dateTime) 
    {
        OnNewDeliver?.Invoke(order, dateTime);
    }
    
}

public class Program
{
    static void Main()
    {
        NotificationSystem notificationSystem = new NotificationSystem();
        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOrder;
        notificationSystem.OnNewDeliver += OrderDeliveredAsync;

        notificationSystem.NewMessage("Messagege");
        notificationSystem.NewOrder("Jrderrer");
        notificationSystem.NewDelivered("Jrderrer", "13pm");
        
    }
    public static async void TestNewMsg(string message)
    {
        await TestNewMsgAsync(message);
    }
    public static async void TestNewOrder(string order)
    {
        await TestNewOrderAsync(order);
    }

    public static async void OrderDeliveredAsync (string order, string dateTime)
    {
        await TestOrderDeliveredAsync(order, dateTime);
    }

    public static async Task TestNewMsgAsync(string message)
    {
        Console.WriteLine($"New message async with data: {message}");
    }

    public static async Task TestNewOrderAsync(string order)
    {
        Console.WriteLine($"New order async with data: {order}");
    }
    //1. Добавить в решение с СУБД события с передаваемым типом 
    public static async Task TestOrderDeliveredAsync(string order, string dateTime)
    {
        Console.WriteLine($"Order '{order}' delivered async. At time {dateTime}");
    }
}   