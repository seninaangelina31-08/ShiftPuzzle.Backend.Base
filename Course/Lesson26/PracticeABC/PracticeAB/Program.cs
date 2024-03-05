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

public class NotificationSystem
{
    public event Func<string, string, Task> OnOrderDelivered;

    public NotificationSystem()
    {
    }

    public async Task NewMessageAsync()
    {
        if (OnNewMessage != null)
        {
            foreach (var handler in OnNewMessage.GetInvocationList())
            {
                await ((Func<Task>)handler)();
            }
        }
    }
    public async Task NewOrderAsync()
    {
        if (OnNewOrder != null)
        {
            foreach (var handler in OnNewOrder.GetInvocationList())
            {
                await ((Func<Task>)handler)();
            }
        }
    }
    public async Task OrderDeliveredAsync(string order, string dateTime)
    {
        if (OnOrderDelivered != null)
        {
            foreach (var handler in OnOrderDelivered.GetInvocationList())
            {
                await ((Func<string, string, Task>)handler)(order, dateTime);
            }
        }
    }
}

public class Program
{
    static async Task Main()
    {
        NotificationSystem notificationSystem = new NotificationSystem();
        notificationSystem.OnNewMessage += TestNewMsgAsync;
        notificationSystem.OnNewOrder += TestNewOrederAsync;
        notificationSystem.OnOrderDelivered += TestOrderDeliveredAsync;

        await notificationSystem.NewMessageAsync();
        await notificationSystem.NewOrderAsync();
        await notificationSystem.OrderDeliveredAsync("Order123", DateTime.Now.ToString());
    }

    public static async Task TestNewMsgAsync()
    {
        Console.WriteLine("Новое сообщения async");
    }

    public static async Task TestNewOrederAsync()
    {
        Console.WriteLine("Новый ордер async");
    }

    public static async Task TestOrderDeliveredAsync(string order, string dateTime)
    {
        Console.WriteLine($"Ордер '{order}' доставлено асинхронно. Во время{dateTime}");
    }
}