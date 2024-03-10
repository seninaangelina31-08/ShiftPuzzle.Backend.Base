
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
    public event Action NewMessage;
    public event Action NewOrder;
    public void OnNewMessage()
    {
        NewMessage?.Invoke();
    }
    public void OnNewOrder()
    {
        NewOrder?.Invoke();
    }
}
public class Program
{
    static void Main()
    {
        // создаем систему уведомлений
        NotificationSystem notificationSystem = new NotificationSystem();
        // создать объект класса уведомлений
        notificationSystem.NewMessage += TestNewMsg;
        notificationSystem.NewOrder += TestNewOreder;
        notificationSystem.OnNewMessage();
        notificationSystem.OnNewOrder();
    }

    // сделать метод асинхронным (Практика Б) и вызвать асинхронный метод TestNewMsgAsync


    // сделать метод асинхронным (Практика Б) и вызвать асинхронный метод TestNewOrederAsync
    public static async void TestNewMsg()
    {
       await TestNewMsgAsync();
    }
    public static async void TestNewOreder()
    {
        await TestNewOrederAsync();
    }


    // создать асинхронный метод TestNewMsgAsync (прописать простой консольный вывод)
    
    // создать асинхронный метод TestNewOrederAsync (прописать простой консольный вывод)
   public static async Task TestNewMsgAsync()
    {
        
        await Console.WriteLine("TestNewMsgAsync текстим");
    }

    public static async Task TestNewOrederAsync()
    {
        
       await Console.WriteLine("TestNewOrederAsync тестим");
    }
}   