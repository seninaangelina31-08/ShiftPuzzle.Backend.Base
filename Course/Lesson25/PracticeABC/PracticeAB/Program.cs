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
    public event Action OnNewMessage;
    public event Action OnNewOrder;

    public async void NewMessageInvoke()
    {
        OnNewMessage?.Invoke();
    }
    public async void NewOrderInvoke()
    {
        OnNewOrder?.Invoke();
    }
}

public class Program
{
    static async Task Main()
    {
        NotificationSystem notificationSystem = new NotificationSystem();

        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOreder;

        notificationSystem.NewMessageInvoke();
        notificationSystem.NewOrderInvoke();
    }

    public static async void TestNewMsg()
    {
        await TestNewMsgAsync();
    }

    public static async void TestNewOreder()
    {
         await TestNewOrderAsync();
    }

    public static async Task TestNewMsgAsync()
    {
        Console.WriteLine("NEW MESSSSAGE!");
    }

   public static async Task TestNewOrderAsync()
    {
        Console.WriteLine("NEW ORRRRRDER!");
    }
}   