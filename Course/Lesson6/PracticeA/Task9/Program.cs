namespace Task9;

class Program
{
    static void Main(string[] args)
    {
        // Пример использования функции
        int number = 17;
        bool isPrime = IsPrime(number);
        Console.WriteLine($"Число {number} простое? {isPrime}");
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}