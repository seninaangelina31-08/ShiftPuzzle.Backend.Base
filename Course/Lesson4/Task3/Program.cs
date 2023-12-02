namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        Array.Reverse(numbers);

        Console.WriteLine("Перевернутый массив:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}