


int[] nums = {17, 120, 58006, 19, 2110, 222, 360};
int k = 0;
do
{
    if (nums[k] % 2 == 0)
    {
        Console.WriteLine(nums[k]);
    }
    k++;
} while (k < nums.Length);
