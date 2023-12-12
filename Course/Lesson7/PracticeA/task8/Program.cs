using System;
namespace task8;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3 };
        subarr(arr);
    }
    public static void subarr(int[] arr, int index = 0, string subset = "")
    {
        if (index == arr.Length)
        {
            Console.WriteLine(subset);
            return;
        }

        subarr(arr, index + 1, subset);

        subset += arr[index] + " ";
        subarr(arr, index + 1, subset);
    }
}
