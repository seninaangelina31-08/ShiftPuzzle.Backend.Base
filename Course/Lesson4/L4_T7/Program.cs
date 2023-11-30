namespace L4_T7;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {123, 124124, 1514, 1280, 1924810, 124812, 419248124, 8124, 81294294, 12894};
        for (int i = 1; i < nums.Length; i += 2)
        {
            Console.WriteLine(nums[i]);
        }
    }
}
