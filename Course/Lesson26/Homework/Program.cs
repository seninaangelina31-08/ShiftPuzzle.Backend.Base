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
            Console.WriteLine("\n1.Заказать пиццу\n2.Выйти");
            Console.Write("Выберите вариант: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                {
                    Console.Write("\nВведите название пиццы: ");
                    string name = Console.ReadLine() ?? "default";
                    
                    deliveryService.NewOrder(name, DateTime.Now.ToString());
                    if (pizzaOrdered > 10)
                    {
                        Console.WriteLine($"Ура!! Вы заказали больше 10 пицц, все следующие заказы будут бесплатны.");
                    }
                    else
                    {
                        Console.WriteLine($"Счет об оплате заказа отправлен Вам на почту.");
                    }
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