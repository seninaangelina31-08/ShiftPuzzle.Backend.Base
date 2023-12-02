namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, -5, 7, -9, 0, -12, 15, -20 };
        int negativeCount = 0;

        foreach (int num in array)
        {
            if (num < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine($"Количество отрицательных чисел в массиве: {negativeCount}");
    }
}