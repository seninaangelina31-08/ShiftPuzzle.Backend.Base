namespace L4_T5;

class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        int[] nums = {123, 0, -3123, -423, 134, 134, 0};
        foreach (int num in nums)
        {
            if (num < 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
