namespace HW_task1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi, i cam summ two numbers!");

        Console.WriteLine("Give me the first number, please: ");
        int num_1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Give me the second number, please: ");
        int num_2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Here is result!");
        Console.Write($"{num_1} + {num_2} = {num_1 + num_2}");
    }
}
