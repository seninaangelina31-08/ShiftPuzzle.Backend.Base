namespace htask1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 2, 2, 3, 1, 4, 4, 4 };

        int most = FindMost(numbers);
        
        Console.WriteLine($"Самый часто встречающийся элемент: {most}");
    }

    static int FindMost(int[] numbers)
    {
        Dictionary<int, int> countDictionary = new Dictionary<int, int>();

        foreach (int number in numbers)
        {
            if (countDictionary.ContainsKey(number))
            {
                countDictionary[number]++;
            }
            else
            {
                countDictionary[number] = 1;
            }
        }

        int maxCount = 0;
        int most = 0;

        foreach (KeyValuePair<int, int> countPair in countDictionary)
        {
            if (countPair.Value > maxCount)
            {
                maxCount = countPair.Value;
                most = countPair.Key;
            }
        }

        return most;
    }
}
