namespace Ex1;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 15, 23, -7, 16, -74, 50, 2};
        int sum = 0;
        foreach(int i in arr)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}
