using System;
using System.Threading.Tasks;

public class NotificationSystem
{
    public event Action<string> OnNewMessage;
    public event Action<string> OnNewOrder;
    public event Action<string> OnDeliveryComplete;

    public NotificationSystem()
    {

    }

    public void NewMessage(string message)
    {
        OnNewMessage?.Invoke(message);
    }

    public void NewOrder(string message)
    {
        OnNewOrder?.Invoke(message);
    }

    public void NewDeliveryComplete(string order)
    {
        OnDeliveryComplete?.Invoke(order);
    }
}

public class Program
{
    static void Main()
    {
        NotificationSystem notificationSystem = new NotificationSystem();
        notificationSystem.OnNewMessage += TestNewMsg;
        notificationSystem.OnNewOrder += TestNewOrder;
        notificationSystem.OnDeliveryComplete += TestDeliveryComplete;

        notificationSystem.NewMessage("new message");
        notificationSystem.NewOrder("new order");
        notificationSystem.NewDeliveryComplete("Delivery completed");
    }

    public static async void TestNewMsg(string message)
    {
        await TestNewMsgAsync(message);
    }

    public static async void TestNewOrder(string message)
    {
        await TestNewOrderAsync(message);
    }

    public static async void TestDeliveryComplete(string message)
    {
        await TestOrderDeliveredAsync(message, DateTime.Now.ToString());
    }

    public static async Task TestNewMsgAsync(string message)
    {
        Console.WriteLine($"New message async: {message}");
    }

    public static async Task TestNewOrderAsync(string message)
    {
        Console.WriteLine($"New order async: {message}");
    }

    public static async Task TestOrderDeliveredAsync(string order, string dateTime)
    {
        Console.WriteLine($"Order '{order}' delivered async. At time {dateTime}");
    }
}
