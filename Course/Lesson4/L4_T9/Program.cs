namespace L4_T9;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 12124, 3, 2, 1, 5};
        
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
    }
}
