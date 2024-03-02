/*
Пратика А:
Система уведомлений:
Создайте простую систему уведомлений,
 где пользователь может подписываться на различные события
 (например, "новое сообщение", "новый заказ" и т. д.)
 и получать уведомления при их возникновении.

 
Пратика Б:

Система обработки асинхронных событий в предыдщуем примере:
Создайте систему обработки асинхронных событий, где различные
 задачи выполняются параллельно. Реализуйте механизм подписки на события
 с возможностью асинхронного выполнения обработчиков событий.
*/

// система уведомлений  
using System;
using System.Collections.Generic;



public class NotificationSystem
{
    public event Action? OnNewMessage;
    public event Action? OnNewOrder;


    public void NewMessage()
    {
        OnNewMessage?.Invoke();
    }

    public void NewOrder()
    {
        OnNewOrder?.Invoke();
    }
}

public class Program
{
    static void Main(string[] args)
    {
        NotificationSystem notificationSystem = new();
        notificationSystem.OnNewMessage += TestNewMsgAsync;
        notificationSystem.OnNewOrder += TestNewOrderAsync;

        notificationSystem.NewMessage();
        notificationSystem.NewOrder();

    }


    public static async void TestNewMsgAsync()
    {
        await Task.Run(() => NewMessageNotification());
    }

    public static async void TestNewOrderAsync()
    {
        await Task.Run(() => NewOrderNotification());
    }

    
    public static void NewOrderNotification()
    {
        Console.WriteLine("Здравсвуйте, новый заказа добавлен в базу данных!");
    }

    public static void NewMessageNotification()
    {
        Console.WriteLine("Здравствуйте, мы что-то сделали, ждём зарплату.........");
    }

}