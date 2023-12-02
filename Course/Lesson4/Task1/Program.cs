namespace Task1;
class Program
{
    static void Main(string[] args)
    {
        int[] a = {1, 2, 4, 5, 6};
        int sum = 0;
        foreach(num in a)
        {
            sum += num;
        }
        Console.WriteLine(sum);
    }
}
