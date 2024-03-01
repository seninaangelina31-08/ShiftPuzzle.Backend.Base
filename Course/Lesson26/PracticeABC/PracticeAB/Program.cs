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
    public event Action <string, string> OnOrderDelivered;
        
    public NotificationSystem()
    { 

    }
// данная обертка нужна для того чтобы вызвать событие, 
//т.к. напрямую вызвать событие нельзя изза того что  фукнция мейн в статическом классе
    public void NewMessage()
    {
        OnNewMessage?.Invoke("текст сообщения");
    }
    public void NewOrder() 
    {
        OnNewOrder?.Invoke("название заказа");
    }
    
    public void NewOrderDelivered()
    {
        OnOrderDelivered?.Invoke("название заказа", "время доставки");
    }
}

public class Program
{
    static void Main()
    {
        NotificationSystem notificationSystem = new NotificationSystem();
        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOreder;
        notificationSystem.OnOrderDelivered += TestOrderDelivered;

        notificationSystem.NewMessage();
        notificationSystem.NewOrder();
        notificationSystem.NewOrderDelivered();
 
        
    }
    public static async void TestNewMsg(string message)
    {
       await TestNewMsgAsync(message);
    }
    public static async void TestNewOreder(string order)
    {
        await TestNewOrederAsync(order);
    }

    public static async void TestOrderDelivered(string order, string dateTime)
    {
        await TestOrderDeliveredAsync(order, dateTime);
    }

    public static async Task TestNewMsgAsync(string message)
    {
        Console.WriteLine($"New message {message} async");
    }

    public static async Task TestNewOrederAsync(string order)
    {
        Console.WriteLine($"New oreder {order} async");
    }

    public static async Task TestOrderDeliveredAsync(string order, string dateTime)
    {
        Console.WriteLine($"Order '{order}' delivered async. At time {dateTime}");
    }
   
}   