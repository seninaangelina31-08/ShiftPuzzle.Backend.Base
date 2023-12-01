namespace Ex5;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 15, 23, -7, 16, -74, 50, 2};
        int count = 0;
        foreach(int i in arr)
        {
            if (i < 0)
            {
                count++;
            } 
        }
        Console.WriteLine(count);
    }
}
