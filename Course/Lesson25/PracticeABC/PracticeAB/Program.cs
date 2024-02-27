using System;

public class NotificationSystem
{
    // Определим события для различных типов уведомлений
    public event Action OnNewMessage;   // событие новое сообщение
    public event Action OnNewOrder;     // событие новый заказ

    // Методы для вызова событий
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
        // создаем систему уведомлений
        // создать объект класса уведомлений
        var notificationSystem = new NotificationSystem();

        // Подписываемся на события
        notificationSystem.OnNewMessage += TestNewMsgAsync;
        notificationSystem.OnNewOrder += TestNewOrderAsync;

        // Генерируем уведомления
        notificationSystem.NewMessage();
        notificationSystem.NewOrder();
    }

    // сделать метод асинхронным (Практика Б) и вызвать TestNewMsgAsync
    // создать асинхронный метод TestNewMsgAsync (прописать простой консольный вывод)
    public static async void TestNewMsgAsync()
    {
        // Простой вывод уведомления
        Console.WriteLine("TestNewMsgAsync.");
    }

    // создать асинхронный метод TestNewOrderAsync (прописать простой консольный вывод)
    public static async void TestNewOrderAsync()
    {
        Console.WriteLine("TestNewOrderAsync.");
    }
}
