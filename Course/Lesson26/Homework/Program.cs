namespace Homework;

class Program
{
    static Order OrderSerice;
    static void Main(string[] args)
    {
        OrderSerice = new Order();
        OrderSerice.OnNewOrder += OrderCreated;
        OrderSerice.OnOrderDelivered += OrderDelivered;
        int pizzaOrdered = 0;
        RunApp(pizzaOrdered);
    }

    public static void OrderCreated(string name, string dateTime)
    {
        Console.WriteLine($"Order created {dateTime} : {name}");
    }

    public static void OrderDelivered(string name, string dateTime)
    {
        Console.WriteLine($"Order delivered {dateTime} : {name}");
    }

    static public async void RunApp(int pizzaOrdered)
    {
        bool isRun = true;
        while (isRun)
        {   
            Console.WriteLine("\n1.Order pizza\n2.Exit");
            Console.Write("Choice : ");
            string choice = Console.ReadLine()!;

            if(choice == "1"){
                Console.Write("\nWrite pizza name: ");
                string name = Console.ReadLine()!;

                OrderSerice.NewOrder(name, DateTime.Now.ToString());
                if (pizzaOrdered > 7)
                {
                    Console.WriteLine($"Congratulations! You have already ordered more than 7 pizzas from us, so all subsequent orders will have a 50% discount. Thank you for choosing us!");
                    pizzaOrdered = -1;
                }
                Console.WriteLine($"An invoice for payment of your order has been sent to you by email.");
                pizzaOrdered += 1;
                OrderSerice.OrderDelivered(name, (DateTime.Now.AddHours(0.5)).ToString());
            }
            else if(choice == "2")
            {
                isRun = false;
            }
            else
            {

            }
        }
    }
}
