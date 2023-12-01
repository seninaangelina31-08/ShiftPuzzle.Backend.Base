namespace Ex9;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 15, 23, -7, 16, -74, 50, 2};
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 0; j < arr.Length-i-1; j++)
            {
                if (arr[j] > arr[j+1])
                {
                    int c = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = c;
                }
            }
        }
        foreach(int i in arr)
        {
            Console.Write($"{i} ");
        }
    }
}
