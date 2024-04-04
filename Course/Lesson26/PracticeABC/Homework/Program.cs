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
        PizaAppRun(deliverySerice, pizzaOrdered);
    }

    public static void OrderDelivered(string name, string dateTime)
    {
        Console.WriteLine($"Заказ доставлен {dateTime} : {name}");
    }

    static public async void PizaAppRun(PizzaDeliveryService deliveryService, int pizzaOrdered)
    {
        while (true)
        {   
            Console.WriteLine("Добро Пожаловать в лучшую пицирию в мире!");
            Console.WriteLine("\n1.Сделать заказ \n2.Выход");
            Console.Write("Выберите вариант : ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "0":
                {
                    Console.Write("\nНапишите название пиццы: ");
                    string name = Console.ReadLine() ?? "default";
                    
                    deliveryService.NewOrder(name, DateTime.Now.ToString());
                    Console.WriteLine("Оплата Проведена!");
                    deliveryService.OrderDelivered(name, (DateTime.Now.AddHours(0.5)).ToString());
                    break;
                }
                case "1":
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
