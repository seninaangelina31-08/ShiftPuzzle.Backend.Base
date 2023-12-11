namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        double celsius = 25;
        double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
        Console.WriteLine($"{celsius} градусов Цельсия = {fahrenheit} градусов Фаренгейта");
    }

    static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}