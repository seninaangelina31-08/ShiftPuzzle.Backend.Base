namespace HomeWork;

using System;

public interface IConsoleWriter
{
    void Write(string format, params object[] args);
    void WriteLine(string format, params object[] args);
}

public class ConsoleWriter : IConsoleWriter
{
    public void Write(string format, params object[] args)
    {
        Console.Write(format, args);
    }

    public void WriteLine(string format, params object[] args)
    {
        Console.WriteLine(format, args);
    }
}

public class PizzaDeliveryService
{
    private readonly IConsoleWriter _consoleWriter;
    private readonly LoyaltySystem _loyaltySystem;

    public PizzaDeliveryService(IConsoleWriter consoleWriter, LoyaltySystem loyaltySystem)
    {
        _consoleWriter = consoleWriter;
        _loyaltySystem = loyaltySystem;
    }

    public void DeliverPizza(string pizzaName)
    {
        _consoleWriter.WriteLine("Доставляем пиццу: {0}", pizzaName);
        _loyaltySystem.AddPoints(10); // За каждую пиццу начисляем 10 бонусных баллов
    }
}

// Система лояльности
public class LoyaltySystem
{
    private int _points;

    public void AddPoints(int points)
    {
        _points += points;
        Console.WriteLine("Накоплено бонусных баллов: {0}", _points);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IConsoleWriter consoleWriter = new ConsoleWriter();
        LoyaltySystem loyaltySystem = new LoyaltySystem();
        PizzaDeliveryService pizzaDeliveryService = new PizzaDeliveryService(consoleWriter, loyaltySystem);

        pizzaDeliveryService.DeliverPizza("Маргарита");
        pizzaDeliveryService.DeliverPizza("Пепперони");
    }
}

