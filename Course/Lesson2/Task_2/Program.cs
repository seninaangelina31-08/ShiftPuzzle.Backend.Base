namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your year of the birth, please: ");
        int year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Your age is {2023 - year}");
    }
}