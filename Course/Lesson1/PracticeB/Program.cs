namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Калькулятор");

        Console.Write("Введите число");
        int numberone = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ваше число {numberone}");

        Console.Write("Введите число");
        int numbetwo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Ваше число {numberone}");
        

        int additions = numberone + numbetwo;
        int subtraction = numberone - numbetwo;
        int multiplication = numberone * numbetwo;
        int division = numberone / numbetwo;

        Console.WriteLine($"Результат сложения: {additions}");
        Console.WriteLine($"Результат вычитания: {subtraction}");
        Console.WriteLine($"Результат умножения: {multiplication}");
        Console.WriteLine($"Результат деления: {division}");
    }
}
