namespace Practice4;

class Program
{
    static void Main(string[] args)
    {
     int[] arr = [2, 3, 1];
        Console.WriteLine(Maxelement(arr, (uint)arr.Length));
        Console.ReadKey(true);
    }
    static int Maxelement(int[] arr, uint size)
    {
        if (size > 1u)
            return Math.Max(arr[size - 1], Maxelement(arr, size - 1));
        return arr[0];
    }
}
