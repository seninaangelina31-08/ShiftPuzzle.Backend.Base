namespace task2;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 4, 0, 7, 17 };
        int maxNumber = numbers[0];

        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        Console.WriteLine("Максимальное значение в массиве: " + maxNumber);
    }
}