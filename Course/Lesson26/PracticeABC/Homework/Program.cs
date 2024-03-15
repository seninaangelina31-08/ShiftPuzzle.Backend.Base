namespace Homework;

class Program
{
    static void Main()
    {
        NotificationSystem notificationSystem = new NotificationSystem();
        PizzaDelivery orderDelivery = new PizzaDelivery();
        notificationSystem.OnNewOrder += orderDelivery.OrderAdd;
        notificationSystem.OnOrderComplited += orderDelivery.OrderFinished;

        PizzaOrder order = new PizzaOrder("Пиперони", 150);
        notificationSystem.NewOrder(order);
        notificationSystem.OrderComplited(order);
    }
}

public class PizzaOrder
{
    public string PizzaName;
    public int PizzaPrice;
    
    public PizzaOrder(string _PizzaName, int _PizzaPrice)
    {
        this.PizzaName = _PizzaName;
        this.PizzaPrice = _PizzaPrice;
    }
}

public class PizzaDelivery
{
    public void OrderAdd(PizzaOrder order)
    {
        Console.WriteLine($"Заказ {order.PizzaName} принят.");
    }

    public void OrderFinished(PizzaOrder order)
    {
        Console.WriteLine($"Заказ {order.PizzaName} доставлен. Вы получили {order.PizzaPrice} рублей.");
    }
}

public  class NotificationSystem
{
    public event Action <PizzaOrder> OnOrderComplited;
    public event Action <PizzaOrder> OnNewOrder; 

    public NotificationSystem(){}
    public void NewOrder(PizzaOrder order) 
    {
        OnNewOrder?.Invoke(order);
    }
    public void OrderComplited(PizzaOrder order)
    {
        OnOrderComplited?.Invoke(order);
    }
}