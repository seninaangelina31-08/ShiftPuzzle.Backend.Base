using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 2, 4, 2, 5, 2, 6 };
        int mostFrequentNumber = FindMostFrequentNumber(numbers);
        Console.WriteLine("Наиболее часто встречающийся элемент: " + mostFrequentNumber);
    }

    static int FindMostFrequentNumber(int[] numbers)
    {
        Dictionary<int, int> numberCount = new Dictionary<int, int>();

        foreach (int number in numbers)
        {
            if (numberCount.ContainsKey(number))
            {
                numberCount[number]++;
            }
            else
            {
                numberCount[number] = 1;
            }
        }

        int maxCount = numberCount.Values.Max();
        int mostFrequentNumber = numberCount.FirstOrDefault(x => x.Value == maxCount).Key;

        return mostFrequentNumber;
    }
}
