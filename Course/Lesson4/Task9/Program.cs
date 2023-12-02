namespace Task9;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, -5, 2, 4, 3 };

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int trash = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = trash;
                }
            }
        }

        Console.WriteLine("Отсортированный массивчик:");   
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
