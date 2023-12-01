namespace task2;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int max = numbers[0];
        
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n; 
            }
        }
        
        
        Console.WriteLine("Максимальный элемент в массиве: " + max);
    }
}

