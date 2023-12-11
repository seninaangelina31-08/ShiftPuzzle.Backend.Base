namespace TaskC;

class Program
{
    static void Main(string[] args)
        
        {
        int[] arr = { 1, 2, 3 };

        List<List<int>> permutations = GeneratePermutations(arr);
        Console.WriteLine("Уникальные перестановки:");
        foreach (var permutation in permutations)
        {
            Console.WriteLine(string.Join(" ", permutation));
        }
    }

    static List<List<int>> GeneratePermutations(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();
        Generate(nums.Length, new List<int>(), new HashSet<int>(), nums, result);
        return result;
    }

    static void Generate(int n, List<int> current, HashSet<int> used, int[] nums, List<List<int>> result)
    {
        if (current.Count == n)
        {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (!used.Contains(nums[i]))
            {
                used.Add(nums[i]);
                current.Add(nums[i]);

                Generate(n, current, used, nums, result);

                used.Remove(nums[i]);
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}