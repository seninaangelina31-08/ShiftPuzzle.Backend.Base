namespace L4_T4;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {12, 123, 214126, 12, 312, 432, 245};
        int k = 0;
        do
        {
            if (nums[k] % 2 == 0)
            {
                Console.WriteLine(nums[k]);
            }
            k++;
        } while (k < nums.Length);
    }
}
