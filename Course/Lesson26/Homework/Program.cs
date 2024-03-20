using System;

namespace PizzaDeliveryApp
{
class Program
{
static void Main(string[] args)
{
    PizzaDeliveryService service = new PizzaDeliveryService();
        Customer customer1 = new Customer("Alice", "1 street");
        Customer customer2 = new Customer("Bob", "2 street");

        service.OrderReceived += customer1.OnOrderReceived;
        service.OrderReceived += customer2.OnOrderReceived;

        service.PlaceOrder("Pepperoni Pizza", customer1);
    }
}

public class PizzaDeliveryService
{
    public event EventHandler<OrderEventArgs> OrderReceived;

    public void PlaceOrder(string pizzaType, Customer customer)
    {
        Console.WriteLine($"Placing order for {pizzaType} for {customer.Name}");
        OnOrderReceived(customer, pizzaType);
    }

    protected virtual void OnOrderReceived(Customer customer, string pizzaType)
    {
        OrderReceived?.Invoke(this, new OrderEventArgs { Customer = customer, PizzaType = pizzaType });
    }
}

public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Customer(string name, string address)
    {
        Name = name;
        Address = address;
    }

    public void OnOrderReceived(object sender, OrderEventArgs e)
    {
        Console.WriteLine($"{Name} received order for {e.PizzaType} at {Address}");
    }
}

public class OrderEventArgs : EventArgs
{
    public Customer Customer { get; set; }
    public string PizzaType { get; set; }
}
}