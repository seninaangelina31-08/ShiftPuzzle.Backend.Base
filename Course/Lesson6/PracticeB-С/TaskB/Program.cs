namespace TaskB;

class Program
{
    static void Main(string[] args)
 {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

        int[] maxSubArray = FindMaxSubArray(arr);
        Console.WriteLine("Подмассив с максимальной суммой элементов:");
        foreach (var num in maxSubArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static int[] FindMaxSubArray(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            return new int[0];

        int maxSum = nums[0];
        int currentSum = nums[0];
        int start = 0;
        int end = 0;
        int currentStart = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > currentSum + nums[i])
            {
                currentSum = nums[i];
                currentStart = i;
            }
            else
            {
                currentSum += nums[i];
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = currentStart;
                end = i;
            }
        }

        int subArrayLength = end - start + 1;
        int[] maxSubArray = new int[subArrayLength];
        Array.Copy(nums, start, maxSubArray, 0, subArrayLength);
        return maxSubArray;
    }
}
