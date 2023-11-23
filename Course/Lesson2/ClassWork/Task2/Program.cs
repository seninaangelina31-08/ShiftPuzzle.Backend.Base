namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("what year were you born: ");
        var currentYear = DateTime.Now.Year;
        Console.WriteLine("You are " + (currentYear - Convert.ToInt32(Console.ReadLine())) + " year.");
    }
}
