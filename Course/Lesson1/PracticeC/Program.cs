namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("Enter the number, please: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Here is your number: {num + 5}");
    }
}
