namespace Homework;



public class PizzaDeliveryService
{
    public event Action<string, string> OnOrderDelivered;
    public event Action<string, string> OnNewOrder;

    public void OrderDelivered(string name, string dateTime)
    {
        OnOrderDelivered?.Invoke(name, dateTime);
    }

    public void NewOrder(string name, string dateTime)
    {
        OnNewOrder?.Invoke(name, dateTime);
    }
}
class Program
{
    static void Main(string[] args)
    {
    
        PizzaDeliveryService deliverySerice = new PizzaDeliveryService();
        deliverySerice.OnNewOrder += CreateOrder;
        deliverySerice.OnOrderDelivered += DeliverOrder;
        int pizzaOrdered = 0;
        Main(deliverySerice, pizzaOrdered);
    }

    public static void CreateOrder(string name, string dateTime)
    {
        Console.WriteLine($"Создан заказ {dateTime} : {name}");
    }

    public static void DeliverOrder(string name, string dateTime)
    {
        Console.WriteLine($"Заказ доставлен {dateTime} : {name}");
    }

    static public async void Main(PizzaDeliveryService deliveryService, int pizzaOrdered)
    {
        while (true)
        {   
            Console.WriteLine("\n1.Заказать пиццу\n2.Выйти");
            Console.Write("Выберите действие : ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                {
                    Console.Write("\nВыберите пиццу: ");
                    string name = Console.ReadLine() ?? "mozzarella";
                    
                    deliveryService.NewOrder(name, DateTime.Now.ToString());
                    if (pizzaOrdered > 30)
                    {
                        Console.WriteLine($"Вы заказали больше 30 пицц!!!!!!!!! Поэтому вы получаете скидку 15%");
                    }
                    else
                    {
                        Console.WriteLine($"Оплата прошла успешно");
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