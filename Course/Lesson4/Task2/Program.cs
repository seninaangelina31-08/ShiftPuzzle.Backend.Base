namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 5, 2, 8, 3 };

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        
        Console.WriteLine("Максимальное значение в массиве: " + max);
    }
}
