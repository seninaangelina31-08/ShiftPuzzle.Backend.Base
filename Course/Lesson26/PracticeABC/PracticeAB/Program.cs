/*
Пратика А:
Система уведомлений:
Создайте простую систему уведомлений,
 где пользователь может подписываться на различные события 
 (например, "новое сообщение", "новый заказ" и т. д.) и 
 получать уведомления при их возникновении.

 
Пратика Б:

Система обработки асинхронных событий в предыдщуем примере:
Создайте систему обработки асинхронных событий,
 где различные задачи выполняются параллельно.
  Реализуйте механизм подписки на события с
   возможностью асинхронного выполнения обработчиков событий.
*/

// система уведомлений  
using System;   
using System.Collections.Generic;



public  class NotificationSystem
{
    public event Action<string>? OnNewMessage;
    public event Action<string>? OnNewOrder;
    public event Action<string, string>? OnOrderDelievered;
        

// данная обертка нужна для того чтобы вызвать событие, 
//т.к. напрямую вызвать событие нельзя изза того что  фукнция мейн в статическом классе
    public void NewMessage()
    {
        OnNewMessage?.Invoke("Я новое сообщение, ДАРОВА!!!!");
    }
    public void NewOrder() 
    {
        OnNewOrder?.Invoke("Новый заказ добавлен в базу данных!!!");
    }
    public void OrderDeliveredMessage()
    {
        OnOrderDelievered?.Invoke("to Akshin: normalEthernet", "AS SOON AS POSSIBLE");
    }
}

public class Program
{
    static void Main()
    {
        NotificationSystem notificationSystem = new();
        notificationSystem.OnNewMessage += TestNewMsgAsync;
        notificationSystem.OnNewOrder += TestNewOrderAsync;
        notificationSystem.OnOrderDelievered += TestOrderDeliveredAsync;

        notificationSystem.NewMessage();
        notificationSystem.NewOrder();
        notificationSystem.OrderDeliveredMessage();
 
        
    }


    public static async void TestNewMsgAsync(string msg)
    {
       await TestNewMsg(msg);
    }

    public static async void TestNewOrderAsync(string msg)
    {
        await TestNewOrder(msg);
    }
    
    public static async void TestOrderDeliveredAsync(string order, string dateTime)
    {
        await TestOrderDelivered(order, dateTime);
    }


    public static async Task TestNewMsg(string msg)
    {
        Console.WriteLine(msg);
    }

    public static async Task TestNewOrder(string msg)
    {
        Console.WriteLine(msg);
    }

    public static async Task TestOrderDelivered(string order, string dateTime)
    {
        Console.WriteLine($"Order '{order}' delivered async. At time: {dateTime}");
    }
   
}   