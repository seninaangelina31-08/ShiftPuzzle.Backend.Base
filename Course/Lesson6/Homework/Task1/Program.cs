int [] numbers = {1, 2, 3, 1, 2, 3};
int mostFrequent = FindMostFrequentElement(numbers);
Console.WriteLine($"Число, которое встречается часще всего в массиве: {mostFrequent}");

static int FindMostFrequentElement(int[] number)
{
    Dictionary<int, int> mostFrequencyMap = new Dictionary<int, int>();

    foreach (int num in number)
    {
        if (mostFrequencyMap.Containskey(num))
        {
            FrequencyMap[num]++;
        }
        else
        {
            FrequencyMap[num] = 1;
        }
    }

    int maxFrequency = FrequencyMap.max(x => x.Value);
    int mostFrequent = FrequencyMap.FirstOrDefalut(x => x.Value == maxFrequency).key;

    return mostFrequent;
}
