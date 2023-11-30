namespace task8;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 4, 0, 7, 17 };
        int maxNumber = numbers[0];
        int minNumber = numbers[0];

        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }
        Console.WriteLine("Максимальное значение в массиве: " + maxNumber);
        Console.WriteLine("Минимальное значение в массиве: " + minNumber);

    }
}