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
    public event Action OnOrderComplited;

    public NotificationSystem()
    { 

    }
// данная обертка нужна для того чтобы вызвать событие, 
//т.к. напрямую вызвать событие нельзя изза того что  фукнция мейн в статическом классе
    public void NewMessage(string text)
    {
        OnNewMessage?.Invoke(text);
    }
    public void NewOrder(string text) 
    {
        OnNewOrder?.Invoke(text);
    }
    public void OrderComplited()
    {
        OnOrderComplited?.Invoke();
    }
}

public class Program
{
    static void Main()
    {
        NotificationSystem notificationSystem = new NotificationSystem();
        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOreder;
        notificationSystem.OnOrderComplited += TestOrederComplited;

        notificationSystem.NewMessage("Hello, World!");
        notificationSystem.NewOrder("Car");
        notificationSystem.OrderComplited();
 
        
    }
    public static async void TestNewMsg(string text)
    {
       await TestNewMsgAsync(text);
    }
    public static async void TestNewOreder(string text)
    {
        await TestNewOrederAsync(text);
    }
    public static async void TestOrederComplited()
    {
        await TestOrederComplitedAsync();
    }

    public static async Task TestNewMsgAsync(string text)
    {
        Console.WriteLine($"New message async: {text}");
    }

    public static async Task TestNewOrederAsync(string text)
    {
        Console.WriteLine($"New oreder async: {text}");
    }
    public static async Task TestOrederComplitedAsync()
    {
        Console.WriteLine("Order complited.");
    }

}   