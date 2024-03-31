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


public  class NotificationSystem
{
    // событие новое сообщение
    public event Action NewMessage;
    // событие новый заказ
    public event Action NewOrder;
    // методы вызова событий, т.к. события вне класса не доступны изза того что main статический
public void OnNewMessage()
{
    NewMessage?.Invoke();
}
public void OnNewOrder();
{
    NewOrder?.Invoke();
}
public NotificationSystem(){}
}

public class Program
{
    static void Main()
    {
        // создаем систему уведомлений
        NotificationSystem notificationSystem = new NotificationSystem();
        // создать объект класса уведомлений
        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOreder;

        notificationSystem.NewMessage();
        notificationSystem.NewOrder();
 
        
    }

    // сделать метод асинхронным (Практика Б) и вызвать асинхронный метод TestNewMsgAsync
    public static void TestNewMsg()
    {
        TestNewMsgAsync();   
    }

    // сделать метод асинхронным (Практика Б) и вызвать асинхронный метод TestNewOrederAsync
    public static void TestNewOreder()
    {
        TestNewOrederAsync();
    }

    // создать асинхронный метод TestNewMsgAsync (прописать простой консольный вывод)
    public static async void TestNewMsgAsync()
    {
        Console.WriteLine("Здравствуй Небо в Облаках!");
    }
    // создать асинхронный метод TestNewOrederAsync (прописать простой консольный вывод)
    public static async void TestNewOrederAsync()
    {
        Console.WriteLine("Здравствуй Юность в Сапогах!");
    }

}   