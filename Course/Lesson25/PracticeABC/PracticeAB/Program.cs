using System;
using System.Threading.Tasks;

public class NotificationSystem
{
    // Объявляем событие нового сообщения
    public event Action OnNewMessage;

    // Метод, который вызывает событие нового сообщения
    public void NewMessage()
    {
        OnNewMessage?.Invoke();
    }

    // Объявляем событие нового заказа
    public event Action OnNewOrder;

    // Метод, который вызывает событие нового заказа
    public void NewOrder()
    {
        OnNewOrder?.Invoke();
    }
}

public class Program
{
    static async Task Main()
    {
        var notificationSystem = new NotificationSystem();

        // Подписываемся на события
        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOrder;

        // Вызываем методы, которые порождают события
        notificationSystem.NewMessage();
        notificationSystem.NewOrder();
    }

    static void TestNewMsg()
    {
        TestNewMsgAsync();
    }

    static void TestNewOrder()
    {
        TestNewOrderAsync();
    }

    // Метод обработки события нового сообщения
    static async Task TestNewMsgAsync()
    {
        Console.WriteLine("Получено новое сообщение!");
    }

    // Метод обработки события нового заказа
    static async Task TestNewOrderAsync()
    {
        Console.WriteLine("Получен новый заказ!");
    }
}