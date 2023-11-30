namespace L4_T10;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {123, 0, 12412, -124, -1241, 1254, 0, -141, 1, 000, 1245, -1240, -01424, 014};
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
    }
}
