using System;
using System.Collections.Generic;

public class NotificationSystem
{
    // Объявляем событие нового сообщения
    public event Action OnNewMessage;

    // Метод, который вызывает событие нового сообщения
    public void NewMessage()
    {
        OnNewMessage?.Invoke();
    }

    // Объявляем событие нового заказа
    public event Action OnNewOrder;

    // Метод, который вызывает событие нового заказа
    public void NewOrder()
    {
        OnNewOrder?.Invoke();
    }
}

public class Program
{
    static void Main()
    {
        var notificationSystem = new NotificationSystem();

        // Подписываемся на события
        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOrder;

        // Вызываем методы, которые порождают события
        notificationSystem.NewMessage();
        notificationSystem.NewOrder();
    }

    public static async void TestNewMsg()
    {
        await TestNewMsgAsync();
    }

    public static async void TestNewOrder()
    {
        await TestNewOrderAsync();
    }

    // Метод обработки события нового сообщения
    static async Task TestNewMsgAsync()
    {
        Console.WriteLine("Получено новое сообщение!");
    }

    // Метод обработки события нового заказа
    static async Task TestNewOrderAsync()
    {
        Console.WriteLine("Получен новый заказ!");
    }
}