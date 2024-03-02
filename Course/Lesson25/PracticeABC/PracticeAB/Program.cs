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



public class NotificationSystem
{
    // событие новое сообщение
    public event Action OnNewMessage;
    // событие новый заказ
    public event Action OnNewOrder;
    // методы вызова событий, т.к. события вне класса не доступны изза того что main статический
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
        NotificationSystem notificationSystem = new NotificationSystem();
        // создаем систему уведомлений
        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOreder;

        notificationSystem.NewMessage();
        notificationSystem.NewOrder();
    }
    public static void TestNewMsg()
    {
        Console.WriteLine("Получено новое сообщение.");
    }

    // сделать метод асинхронным (Практика Б) и вызвать асинхронный метод TestNewOrederAsync
    public static void TestNewOreder()
    {
        Console.WriteLine("Пришел новый заказ.");
    }
}   