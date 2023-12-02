namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            int trash = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = trash;
        }
        Console.Write("Обратный порядок массивчика: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);
        }
    }
}
