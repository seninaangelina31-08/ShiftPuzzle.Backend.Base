namespace _10;

class Program
{
    static void Main(string[] args)
    {
        int minRange = 1;
        int maxRange = 10;

        int randomNum = GenerateRandomNumber(minRange, maxRange);
        Console.WriteLine($"Случайное число в диапазоне от {minRange} до {maxRange}: {randomNum}");
    }

    static int GenerateRandomNumber(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max + 1);
    }
}
