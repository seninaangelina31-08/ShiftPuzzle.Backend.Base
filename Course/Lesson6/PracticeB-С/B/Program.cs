using System;

class Program
{
    static int[] FindMaxSubarray(int[] array)
    {
        int maxSum = array[0];
        int currentSum = array[0];
        int startIndex = 0;
        int endIndex = 0;
        int currentStartIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = array[i];
                currentStartIndex = i;
            }
            else
            {
                currentSum += array[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                startIndex = currentStartIndex;
                endIndex = i;
            }
        }

        int[] subarray = new int[endIndex - startIndex + 1];
        Array.Copy(array, startIndex, subarray, 0, subarray.Length);
        return subarray;
    }

    static void Main()
    {
        int[] array = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int[] maxSubarray = FindMaxSubarray(array);

        Console.WriteLine("Максимальная сумма подмассива: " + maxSubarray.Sum());
        Console.WriteLine("Максимальный подмассив: " + string.Join(", ", maxSubarray));
    }
}
