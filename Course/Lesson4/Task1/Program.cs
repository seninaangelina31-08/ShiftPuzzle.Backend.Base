namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {12, 124, 0, 65};
        int sum = 0;

        foreach (int el in numbers)
        {
            sum += el;

        }
        
        Console.WriteLine($"Сумма всех элементов в массиве: {sum}");
    }
}
