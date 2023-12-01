namespace Ex4;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 15, 23, -7, 16, -74, 50, 2};
        foreach(int i in arr)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
