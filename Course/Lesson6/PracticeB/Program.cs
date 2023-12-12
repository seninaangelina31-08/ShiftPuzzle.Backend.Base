using System;

namespace PracticeB;

class Program
{
    static void Main()
    {
        int[] nums = { -9, 1, 3, 4, 5, 2, 1};
        int[] subarray = FindMax(nums);

        Console.WriteLine("Maximum Subarray:");
        foreach (int num in subarray)
        {
            Console.Write(num + " ");
        }
    }

     public static int[] FindMax(int[] nums)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            currentSum += nums[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                endIndex = i;
            }

            if (currentSum <= 0)
            {
                currentSum = 0;
                startIndex = i + 1;
            }
        }

        int[] subarray = new int[endIndex - startIndex + 1];
        Array.Copy(nums, startIndex, subarray, 0, endIndex - startIndex + 1);

        return subarray;
    }
}
