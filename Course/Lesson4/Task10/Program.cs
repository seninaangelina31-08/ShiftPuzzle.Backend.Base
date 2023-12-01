


int[] nums = {222, 7, 2111, -365, -2111, 1254, 6, -666, 0, 3000, 1234567};
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] < 0)
    {
        nums[i] = 0;
    }
}
        
foreach (int num in nums)
{
    Console.WriteLine(num);
}