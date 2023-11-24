namespace PracticeD;
class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Press Enter");
            Console.WriteLine($"{counter} click");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                counter++;
            }
            else
            {
                break;
            }
        }
        
        
    }
}
