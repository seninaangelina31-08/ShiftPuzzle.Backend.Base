namespace PracticeA;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 2, 2, 4, 5, 2, 6, 2 };

        int mostFrequent = FindMostFrequentElement(arr);
        Console.WriteLine($"Самый часто встречающийся элемент: {mostFrequent}");
    }

    static int FindMostFrequentElement(int[] nums)
    {
        if (nums == null || nums.Length == 0)
            throw new ArgumentException("Массив пуст");

        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (frequencyMap.ContainsKey(num))
                frequencyMap[num]++;
            else
                frequencyMap[num] = 1;
        }

        int mostFrequentElement = frequencyMap.OrderByDescending(kv => kv.Value).First().Key;
        return mostFrequentElement;
    }
}
