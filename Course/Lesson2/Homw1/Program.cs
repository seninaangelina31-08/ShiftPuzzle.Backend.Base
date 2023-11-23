namespace Homw1;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число: "); 
        int num1 = Convert.ToInt32(Console.ReadLine()); 

        Console.WriteLine("Введите второе число: "); 
        int num2 = Convert.ToInt32(Console.ReadLine()); 

        int sum = num1 + num2; 

        Console.WriteLine("Сумма чисел " + num1 + " и " + num2 + " равна: " + sum ); 
    }
}
