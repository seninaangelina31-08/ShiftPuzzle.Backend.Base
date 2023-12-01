namespace Ex7;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 15, 23, -7, 16, -74, 50, 2};
        for(int i = 0; i < arr.Length; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
