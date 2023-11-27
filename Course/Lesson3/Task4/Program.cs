namespace Task4;

class Program
{
    static void Main(string[] args)
    {
    int[] numbers = { 2, 5, 8, 10, 13, 16, 20 };

        Console.WriteLine("Четные числа из массива:");

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.WriteLine(numbers[i]);
            }
    }
}
}