using System.Diagnostics.CodeAnalysis;

namespace task1;

class Program
{
    static void Main()
    {
        int sum_n = 0;
        int[] array = {1,2,3};
        foreach(int arr in array)
        {
            sum_n += arr;
        }
        Console.WriteLine(sum_n);
    }
}
