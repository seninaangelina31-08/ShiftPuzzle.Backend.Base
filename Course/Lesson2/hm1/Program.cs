namespace hm1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The sum is " + (a + b));
    }
}
