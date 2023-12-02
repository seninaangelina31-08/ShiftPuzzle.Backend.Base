namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine("Сумма элементов массива: " + sum);
    }
}