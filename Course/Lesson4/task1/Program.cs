namespace task1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = 0;
        
        foreach (int num in numbers)
        {
            sum += num;
        }
        
        Console.WriteLine("Сумма всех элементов массива: " + sum);
    }

}
