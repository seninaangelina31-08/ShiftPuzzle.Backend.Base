namespace PracticeC;

class Program
{
     public static void FindPermutations(int[] nums)
    {
        int[] permutation = new int[nums.Length];
        bool[] used = new bool[nums.Length];

        Permute(nums, permutation, used, 0);
    }

    public static void Permute(int[] nums, int[] permutation, bool[] used, int rec_depth)
    {
        if (rec_depth == nums.Length)
        {
            PrintPermutation(permutation);
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (used[i] == false)
            {
                permutation[rec_depth] = nums[i];
                used[i] = true;
                Permute(nums, permutation, used, rec_depth + 1);
                used[i] = false;
            }
        }
    }

    public static void PrintPermutation(int[] permutation)
    {
        foreach (int num in permutation)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        int[] nums = {1, 2, 3};
        FindPermutations(nums);
    }
}
