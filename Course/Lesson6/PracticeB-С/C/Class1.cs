namespace C;

public class Class1
{
    public static List<List<int>> GetPermutations(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();
        GeneratePermutations(nums, new List<int>(), new HashSet<int>(), result);
        return result;
    }

    private static void GeneratePermutations(int[] nums, List<int> currentPerm, HashSet<int> usedNums, List<List<int>> result)
    {
        if (currentPerm.Count == nums.Length)
        {
            result.Add(new List<int>(currentPerm));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (!usedNums.Contains(nums[i]))
            {
                currentPerm.Add(nums[i]);
                usedNums.Add(nums[i]);

                GeneratePermutations(nums, currentPerm, usedNums, result);

                currentPerm.RemoveAt(currentPerm.Count - 1);
                usedNums.Remove(nums[i]);
            }
        }
    }

    public static void Main()
    {
        int[] nums = { 1, 2, 3 };
        List<List<int>> permutations = GetPermutations(nums);

        foreach (List<int> permutation in permutations)
        {
            Console.WriteLine(string.Join(" ", permutation));
        }
    }
}
