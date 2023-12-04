namespace PracticeB;

class Program
{
    static void Main(string[] args)

    {   Console.Write("Write the first number: ");
        int num_1 = Convert.ToInt32(Console.ReadLine());

         Console.Write("Write the second number: ");
        int num_2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Addition: {num_1 + num_2}" );
        Console.WriteLine($"Subtraction: {num_1 - num_2}" );
        Console.WriteLine($"Division: {num_1 / num_2}");
        Console.WriteLine($"Multiplication: {num_1 * num_2}");
    }
}
