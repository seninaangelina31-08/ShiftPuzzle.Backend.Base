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


namespace PracticeAB
{
public class NotificationSystem
{
    // событие новое сообщение
    public event Action OnNewMessage;
    // событие новый заказ
    public event Action OnNewOrder;
    // методы вызова событий, т.к. события вне класса не доступны изза того что main статический
    public void NewMessage()
    {
        OnNewMessage.Invoke();
    }
    public void NewOrder()
    {
        OnNewOrder.Invoke();
    }

}

public class Program
{
    static void Main()
    {
        // создаем систему уведомлений
        NotificationSystem notificationSystem = new NotificationSystem();
        // создать объект класса уведомлений
        //notificationSystem.OnNewMessage += TestNewMsg;

        notificationSystem.OnNewMessage += TestNewMsg;
        //notificationSystem.OnNewOrder += TestNewOreder;
        notificationSystem.OnNewOrder += TestNewOrder;
        //notificationSystem.NewMessage();
        notificationSystem.NewMessage();
        //notificationSystem.NewOrder();
        notificationSystem.NewOrder();
 
        
    }

    // сделать метод асинхронным (Практика Б) и вызвать асинхронный метод TestNewMsgAsync
    public static async void TestNewMsg()
    {
        await TestNewMsgAsync();
    }
    public static async Task TestNewMsgAsync()
    {
        Console.WriteLine("Получено новое сообщение.");
    }
    // сделать метод асинхронным (Практика Б) и вызвать асинхронный метод TestNewOrederAsync
    public static async void TestNewOrder()
    {
        await TestNewOrderAsync();
    }
    public static async Task TestNewOrderAsync()
    {
         Console.WriteLine("Пришел новый заказ.");
    }
    

    // создать асинхронный метод TestNewMsgAsync (прописать простой консольный вывод)

    // создать асинхронный метод TestNewOrederAsync (прописать простой консольный вывод)
   
}
}