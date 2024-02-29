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
        
    public NotificationSystem()
    { 

    }
// данная обертка нужна для того чтобы вызвать событие, 
//т.к. напрямую вызвать событие нельзя изза того что  фукнция мейн в статическом классе
    public void NewMessage(string mess)
    {
        OnNewMessage?.Invoke(mess);
    }
    public void NewOrder(string order) 
    {
        OnNewOrder?.Invoke(order);
    }
}

public class Program
{
    static void Main()
    {
        NotificationSystem notificationSystem = new NotificationSystem();
        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOreder;

        notificationSystem.NewMessage("New message");
        notificationSystem.NewOrder("New Order");
 
        
    }
    public static async void TestNewMsg(string mess)
    {
       await TestNewMsgAsync(mess);
    }
    public static async void TestNewOreder(string order)
    {
        await TestNewOrederAsync(order);
    }

    public static async Task TestNewMsgAsync(string mess)
    {
        Console.WriteLine($"New message async: {mess}");

    }

    public static async Task TestNewOrederAsync(string order)
    {
        Console.WriteLine($"New order async: {order}");
    }
   
}   