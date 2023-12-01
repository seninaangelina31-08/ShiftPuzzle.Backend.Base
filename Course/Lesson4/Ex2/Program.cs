namespace Ex2;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 15, 23, -7, 16, -74, 50, 2};
        int max = arr[0];
        foreach(int i in arr)
        {
            if (i > max)
                max = i;
        }
        Console.WriteLine(max);
    }
}
