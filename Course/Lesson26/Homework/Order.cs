public class Order
{
    public event Action<string, string> OnNewOrder;
    public event Action<string, string> OnOrderDelivered;

    public void NewOrder(string name, string dateTime)
    {
        OnNewOrder?.Invoke(name, dateTime);
    }
    public void OrderDelivered(string name, string dateTime)
    {
        OnOrderDelivered?.Invoke(name, dateTime);
    }
}