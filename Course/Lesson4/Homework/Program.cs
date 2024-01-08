namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    //task 1
    static int[] splitArray(int[] arrA, int[] arrB)
    {
        int[] result = new int[arrA.Length + arrB.Length];
        for (int i = 0; i < result.Length; i++)
        {
            if (i < arrA.Length)
            {
                result[i] = arrA[i];
            }
            else
            {
                result[i] = arrB[i - arrA.Length];
            }
        }
        return result;
    }

    //task 2
    static int[] reverseNum(int[] arr, int num)
    {
        int[] result = new int[arr.Length];
        if (num > arr.Length)
        {
            num = arr.Length;
        }
        for (int i = arr.Length - num; i < arr.Length; i++)
        {
            result[i + num - arr.Length] = arr[i];
        }
        for (int i = 0; i < arr.Length - num; i++)
        {
            result[i + num] = arr[i];
        }
        return result;
    }
}
