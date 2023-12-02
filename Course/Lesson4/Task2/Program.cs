namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        int[] a = {1, 2, 4, 5, 6};
        int max = a[0];
        foreach(num in a)
        {
            max = max < num? num : max;
        }
        Console.WriteLine(max);
    }
}
