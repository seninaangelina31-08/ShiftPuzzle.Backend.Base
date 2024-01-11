using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3 };

        List<int[]> permutations = GenerateUniquePermutations(numbers);

        foreach (var permutation in permutations)
        {
            Console.WriteLine(string.Join(", ", permutation));
        }
    }

    static List<int[]> GenerateUniquePermutations(int[] numbers)
    {
        List<int[]> permutations = new List<int[]>();

        GeneratePermutations(numbers, 0, permutations);

        return permutations;
    }

    static void GeneratePermutations(int[] numbers, int index, List<int[]> permutations)
    {
        if (index == numbers.Length - 1)
        {
            permutations.Add((int[])numbers.Clone());
            return;
        }

        for (int i = index; i < numbers.Length; i++)
        {
            Swap(numbers, index, i);
            GeneratePermutations(numbers, index + 1, permutations);
            Swap(numbers, index, i);
        }
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
