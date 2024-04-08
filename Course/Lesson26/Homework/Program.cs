namespace Homework;

public class PizzaDeliveryService
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
class Program
{
    static void Main(string[] args)
    {
    
        PizzaDeliveryService deliverySerice = new PizzaDeliveryService();
        deliverySerice.OnNewOrder += OrderCreated;
        deliverySerice.OnOrderDelivered += OrderDelivered;
        int pizzaOrdered = 0;
        RunApp(deliverySerice, pizzaOrdered);
    }

    public static void OrderCreated(string name, string dateTime)
    {
        Console.WriteLine($"Создан заказ {dateTime} : {name}");
    }

    public static void OrderDelivered(string name, string dateTime)
    {
        Console.WriteLine($"Заказ доставлен {dateTime} : {name}");
    }

    static public async void RunApp(PizzaDeliveryService deliveryService, int pizzaOrdered)
    {
        while (true)
        {   
            Console.WriteLine("\n1.Заказать пиццу\n2.Выход");
            Console.Write("Выберите вариант : ");
            string choice = Console.ReadLine()!;

            switch (choice)
            {
                case "1":
                {
                    Console.Write("\nНапишите название пиццы: ");
                    string name = Console.ReadLine()!;
                    
                    deliveryService.NewOrder(name, DateTime.Now.ToString());
                    if (pizzaOrdered > 5)
                    {
                        Console.WriteLine($"Поздравляем! Вы заказали у нас уже больше 5 пицц, поэтому все последующие заказы будут со скидкой 25%. Спасибо что выбираете нас!");
                    }
                    Console.WriteLine($"Счет об оплате заказа выслан вам на почту.");
                    pizzaOrdered += 1;
                    deliveryService.OrderDelivered(name, (DateTime.Now.AddHours(0.5)).ToString());
                    break;
                }
                case "2":
                {
                    return;
                }
                default :
                {
                    break;
                }
            }
        }
    }
}