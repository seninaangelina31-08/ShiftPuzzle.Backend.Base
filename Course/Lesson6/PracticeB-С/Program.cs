<<<<<<< HEAD
﻿// task1
void MaxSumSubArray(int[] arr, int N)
{
    int[] maxArray = new int[N];
    int maxSum = 0;

    for (int i = 0; i < arr.Length - N + 1; i++)
    {
        int tempSum = 0;
        int[] subArray = new int[N];
        for (int j = 0; j < N; j++)
        {
            subArray[j] = arr[i + j];
            tempSum += arr[i + j];
        }

        if (tempSum > maxSum)
        {
            maxSum = tempSum;
            maxArray = subArray;
        }
    }
    Console.WriteLine($"Исходный массив [{string.Join(", ", arr)}] \nПодмассив с максимальной суммой элементов: [{string.Join(", ", maxArray)}]");
}
int[] array = {42, 5, 51, 25, 58, 11, 13, 4, 23, 96, 7, 56};
MaxSumSubArray(array, 3);

// task2
// -_-

=======
﻿namespace PracticeB_С;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int[] maxSubarray = FindMaxSubarray(arr);

        Console.Write("Max subarray with maximum sum: ");
        foreach (int num in maxSubarray)
        {
            Console.Write(num + " ");
        }
    }

    public static int[] FindMaxSubarray(int[] arr)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;
        int start = 0;
        int end = 0;
        int s = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            currentSum += arr[i];

            if (maxSum < currentSum)
            {
                maxSum = currentSum;
                start = s;
                end = i;
            }

            if (currentSum < 0)
            {
                currentSum = 0;
                s = i + 1;
            }
        }

        int[] result = new int[end - start + 1];
        Array.Copy(arr, start, result, 0, end - start + 1);
        return result;
    }
    
}
>>>>>>> main
