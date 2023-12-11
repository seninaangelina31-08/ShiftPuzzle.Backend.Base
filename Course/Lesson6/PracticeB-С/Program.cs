using System;
using System.Collections.Generic;
namespace PracticeB_С;

class Program
{


    static public int[] Task1(int[] arr) {
        int n = arr.Length, l = 0, r = 0, max = 0;
        int[] pref_sum = new int[n];
        pref_sum[0] = arr[0];
        for (int i = 1; i < n; i++) {
            pref_sum[i] = pref_sum[i-1]+arr[i];
        }
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < i; j++) {
                if (pref_sum[i]-pref_sum[j] > max) {
                    max = pref_sum[i]-pref_sum[j];
                    l = j;
                    r = i;
                }
            }
        }
        int[] fin = new int[r-l+1];
        for (int i = l+1; i < r+1; i++) {
            fin[i-l] = arr[i];
        }
        return fin;



    }


    static void MainB(string[] args) {
        int[] arr = {1, 2, 5, -8, -6, 9, 6, 3, -4, 7};
        arr = Task1(arr);
        for (int i = 1; i < arr.Length; i++) {
            Console.Write(arr[i]+" ");
        }
    }



}


public class PermutationGenerator
{
    public List<List<int>> GeneratePermutations(int[] nums)
    {
        List<List<int>> result = new List<List<int>>();
        List<int> currentPermutation = new List<int>();
        bool[] used = new bool[nums.Length];
        
        Generate(nums, currentPermutation, used, result);
        
        return result;
    }

    private void Generate(int[] nums, List<int> currentPermutation, bool[] used, List<List<int>> result)
    {
        if (currentPermutation.Count == nums.Length)
        {
            result.Add(new List<int>(currentPermutation));
            return;
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (!used[i])
            {
                currentPermutation.Add(nums[i]);
                used[i] = true;
                
                Generate(nums, currentPermutation, used, result);
                
                currentPermutation.RemoveAt(currentPermutation.Count - 1);
                used[i] = false;
            }
        }
    }
}

public class TaskC
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        
        PermutationGenerator permutationGenerator = new PermutationGenerator();
        List<List<int>> permutations = permutationGenerator.GeneratePermutations(nums);
        
        foreach (List<int> permutation in permutations)
        {
            Console.WriteLine(string.Join(", ", permutation));
        }
    }
}

