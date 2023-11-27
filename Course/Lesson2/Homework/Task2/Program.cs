namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        int a = 1343684;
        Console.WriteLine("Попробуйте угадать число");
        int b = Int32.Parse(Console.ReadLine());
        while (b!=a) {
            if (b < a) {
                Console.WriteLine('>');
            } else {
                Console.WriteLine('<');
            }
            b = Int32.Parse(Console.ReadLine());
        }
        Console.WriteLine("Congrats");
        
    }
}
