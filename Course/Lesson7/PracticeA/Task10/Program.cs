List<int> initialList = new List<int> { 1, 2, 3 };
GeneratePermutations(initialList, 0, initialList.Count);

static void GeneratePermutations<T>(List<T> list, int start, int end)
{
    if (start == end - 1)
    {
        Console.WriteLine(string.Join(", ", list));
        }
        else
        {
            for (int i = start; i < end; i++)
            {
                Swap(list, start, i);
                GeneratePermutations(list, start + 1, end);
                Swap(list, start, i);
            }
        }
    }

    static void Swap<T>(List<T> list, int index1, int index2)
    {
        T temp = list[index1];
        list[index1] = list[index2];
        list[index2] = temp;
    }
