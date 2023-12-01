namespace Ex8;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 15, 23, -7, 16, -74, 50, 2};
        int min = arr[0], max = arr[0];
        foreach(int i in arr)
        {
            if (i > max)
                max = i;
            if (i < min)
                min = i;
        }
        Console.WriteLine($"Максимальное число в массиве: {max} \nМинимальное число в массиве: {min}");
    }
}
