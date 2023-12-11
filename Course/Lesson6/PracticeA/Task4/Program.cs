namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        int number = 7;
        bool isEven = Even(number);
        Console.WriteLine($"Число {number} четное? {isEven}");
    }

    static bool Even(int number)
    {
        return number % 2 == 0;
    }
}