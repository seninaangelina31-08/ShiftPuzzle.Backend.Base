namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте! Я мини-калькулятор! Умею только складывать небольшие числа!");
        Console.WriteLine("Введите первое любое небольшое число: ");
        int num1 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите второе любое небольшое число: ");
        int num2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine((num1+num2));
    }
}
