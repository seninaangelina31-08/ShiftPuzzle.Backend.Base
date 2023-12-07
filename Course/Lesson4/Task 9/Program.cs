namespace Task_9;

class Program
{
    static void Main(string[] args)
    {
    int[] mass = {1,324,46,7,8,10};
    Array.Sort(mass);
    Console.WriteLine(String.Join(", ", mass));
    }
}
