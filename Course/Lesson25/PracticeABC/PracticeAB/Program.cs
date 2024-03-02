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

// Система уведомлений
public class NotificationSystem
{
    // Определение событий
    public event Action OnNewMessage;
    public event Action OnNewOrder;

    // Методы вызова событий
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
    static void Main()
    {
        // Создание объекта класса уведомлений
        NotificationSystem notificationSystem = new NotificationSystem();

        // Подписка на события
        notificationSystem.OnNewMessage += TestNewMsgAsync;
        notificationSystem.OnNewOrder += TestNewOrederAsync;

        // Вызов событий
        notificationSystem.NewMessage();
        notificationSystem.NewOrder();
    }

    // Сделать метод асинхронным и вызвать асинхронный метод TestNewMsgAsync
    public static async void TestNewMsgAsync()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Получено новое сообщение.");
        });
    }

    // Сделать метод асинхронным и вызвать асинхронный метод TestNewOrederAsync
    public static async void TestNewOrederAsync()
    {
        await Task.Run(() =>
        {
            Console.WriteLine("Получен новый заказ.");
        });
    }
}