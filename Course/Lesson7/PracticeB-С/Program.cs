namespace PracticeB_С;
class Program
{
    static void Main(string[] args)
    {
    }
    static void QuickSortAlgorithm(int[] array, int low, int high)
{
    if (low < high)
    {
        int pivotIndex = Partition(array, low, high);

        QuickSortAlgorithm(array, low, pivotIndex - 1);
        QuickSortAlgorithm(array, pivotIndex + 1, high);
    }
}

static int Partition(int[] array, int low, int high)
{
    int pivot = array[high];
    int i = low - 1;

    for (int j = low; j < high; j++)
    {
        if (array[j] < pivot)
        {
            i++;
            Swap(ref array[i], ref array[j]);
        }
    }

    Swap(ref array[i + 1], ref array[high]);
    return i + 1;
}

static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
}
