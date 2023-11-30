namespace L4_T8;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {123123, 15125, 41234124, 12414, 1241516, 14125, 135136, 1241256, 15135,};
        int smallest = nums[0];
        int biggest = nums[0];
        foreach (var num in nums)
        {
            if (smallest > num)
            {
                smallest = num;
            }
            if (biggest < num)
            {
                biggest = num;
            }
        }
        Console.WriteLine($"Самое большое число в массиве это {biggest}");
        Console.WriteLine($"Самое маленькое число в массиве это {smallest}");
    }
}
