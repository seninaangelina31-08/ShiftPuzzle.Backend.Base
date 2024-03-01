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
    public event EventHandler<string> NewMessage;
    public event EventHandler<string> NewOrder;

    public void TriggerNewMessage(string message)
    {
        NewMessage?.Invoke(this, message);
    }

    public void TriggerNewOrder(string order)
    {
        NewOrder?.Invoke(this, order);
    }
    public static async void TestNewMsg(string message)
    {
        await NewMessage?.InvokeAsync(message);
    }
    public static async void TestNewOreder(string order)
    {
        await NewOrder?.InvokeAsync(order);
    }

}

public class Program
{
    static void Main()
    {
        var eventManager = new NotificationSystem();

        eventManager.NewMessage += (sender, message) =>
        {
            Console.WriteLine($"Получено новое сообщение: {message}");
        };

        eventManager.NewOrder += (sender, order) =>
        {
            Console.WriteLine($"Получен новый заказ: {order}");
        };
        eventManager.TriggerNewMessage("Привет, мир!");

        eventManager.TriggerNewOrder("Заказ №12345");
 
        
    }

   
}   