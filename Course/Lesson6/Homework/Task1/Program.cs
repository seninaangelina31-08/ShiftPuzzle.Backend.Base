namespace Task1;

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main() {
        int[] numbers = { 1, 2, 3, 4, 5, 2, 3, 2, 2, 6, 7, 7, 7, 7 };
        int mostFrequent = FindMostFrequentElement(numbers);
        Console.WriteLine("The Most Frequent " + mostFrequent);
    }

    static int FindMostFrequentElement(int[] array) {
        Dictionary<int, int> frequencies = new Dictionary<int, int>();

        foreach (int num in array) {
            if (frequencies.ContainsKey(num)) {
                frequencies[num]++;
            }
            else {
                frequencies[num] = 1;
            }
        }

        int mostFrequent = frequencies.OrderByDescending(x => x.Value).First().Key;
        return mostFrequent;
    }
}

