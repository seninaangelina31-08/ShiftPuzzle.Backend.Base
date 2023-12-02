namespace Task8;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 7, -2 };
        int min = arr[0];
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        
        Console.WriteLine($"Минимальный элемент массива: {min}");
        Console.WriteLine($"Максимальный элемент массива: {max}");
    }
}
