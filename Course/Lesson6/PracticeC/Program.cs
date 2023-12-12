using System.Collections.Generic;
using System;
namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3 };
        List<List<int>> permutations = GeneratePermutations(nums);
        
        foreach (List<int> permutation in permutations)
        {
            Console.WriteLine(string.Join(" ", permutation));
        }
    }
    public static List<List<int>> GeneratePermutations(int[] nums)
    {
        List<List<int>> permutations = new List<List<int>>();
        GeneratePermutations(nums, new bool[nums.Length], new List<int>(), permutations);
        return permutations;
    }
    
    private static void GeneratePermutations(int[] nums, bool[] used, List<int> current, List<List<int>> permutations)
    {
        if (current.Count == nums.Length)
        {
            permutations.Add(new List<int>(current));
            return;
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (!used[i])
            {
                current.Add(nums[i]);
                used[i] = true;
                GeneratePermutations(nums, used, current, permutations);
                used[i] = false;
                current.RemoveAt(current.Count - 1);
            }
        }
    }

}
