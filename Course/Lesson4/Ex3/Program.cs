namespace Ex3;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 15, 23, -7, 16, -74, 50, 2};
        int l = arr.Length;
        for(int i = 0; i < l/2; i++)
        {
            int c = arr[i];
            arr[i] = arr[l-i-1];
            arr[l-i-1] = c;
        }
        foreach(int i in arr)
        {
            Console.Write($"{i} ");
        }
    }
}
