namespace PracticeBC;

class Program
{
    public static int[] MaxSum(int[] nums)
    {
        int maxSum = nums[0];
        int currentSum = nums[0];
        int start = 0;
        int end = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (currentSum < 0)
            {
                currentSum = nums[i];
                start = i;
                end = i;
            }
            else
            {
                currentSum += nums[i];
                end = i;
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }

        int[] subarray = new int[end - start + 1];

        for (int i = start; i <= end; i++)
        {
            subarray[i - start] = nums[i];
        }

        return subarray;
    }

static void Main(string[] args)

    {
        int[] nums = { 1, 2, 4, -3, -5, 5, 2, 6};
        int[] subarr = MaxSum(nums);

        Console.WriteLine(string.Join(", ", subarr)); 
    }
}



