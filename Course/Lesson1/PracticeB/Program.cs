namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Калькулятор");  
    
    Console.Write("Введите свое первое число: ");
    int numberone = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Ваше число: {numberone}");
    
    Console.Write("Введите свое второе число: ");
    int numbertwo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Ваше число: {numbertwo}");

    int additions = numberone + numbertwo;
    int subtraction = numberone - numbertwo;
    int multiplication = numberone * numbertwo;
    int division = numberone / numbertwo;
    
    Console.WriteLine($"Результат сложение: {additions}");
    Console.WriteLine($"Результат вычитание: {subtraction}");
    Console.WriteLine($"Результат умножение: {multiplication}");
    Console.WriteLine($"Результат деление: {division}");
    }
}
