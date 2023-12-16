namespace Task8;

class Program
{
    public static void GenerateSubsets<T>(List<T> set)
    {
        GenerateSubsets(set, new List<T>(), 0);
    }

    private static void GenerateSubsets<T>(List<T> set, List<T> currentSubset, int index)
    {
        Console.WriteLine("{" + string.Join(", ", currentSubset) + "}");

        for (int i = index; i < set.Count; i++)
        {
            currentSubset.Add(set[i]);

            GenerateSubsets(set, currentSubset, i + 1);

            currentSubset.RemoveAt(currentSubset.Count - 1);
        }
    }

    static void Main()
    {
        List<int> exampleSet = new List<int>() { 1, 2, 3 };
        GenerateSubsets(exampleSet);
    }
}