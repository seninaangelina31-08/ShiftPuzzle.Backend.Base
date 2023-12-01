


int[] nums = {10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 121240};
        
for (int line = 0; line < nums.Length; line++)
{   
    Console.WriteLine($"Заход {line}");
    for (int num = 0; num < nums.Length - 1 - line; num++)
    {
        Console.WriteLine($"{nums[num]} {nums[num + 1]}");
        Console.WriteLine();
        if (nums[num] > nums[num + 1])
        {
            int first = nums[num];
            int second = nums[num + 1];
            nums[num] = second;
            nums[num + 1] = first;
        }
    }
}
        
foreach (int num in nums)
{
    Console.WriteLine(num);
}