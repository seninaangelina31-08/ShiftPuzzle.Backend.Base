namespace task2;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 3, 4, 5};
        int max = nums[0];
        for (int i = 0; i < 5; i++){
            if (max < nums[i]) {
                max = nums[i];
            }
        }
        Console.WriteLine(max);
    }
}
