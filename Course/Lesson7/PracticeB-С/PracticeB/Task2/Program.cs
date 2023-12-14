namespace Task2;

class Program
{
    public static void Sort(int[] array, int left, int right)
    {
        if (left < right)
 {          foreach (int el in array)
            // {
                // Console.Write(el + " ");
            // }
            Console.WriteLine();
            int index = Pivot(array, left, right);
            Sort(array, left, index - 1);
            Sort(array, index + 1, right);
        }
    }

    public static int Pivot(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    static void Main(string[] args)
    {
        int[] array = {5, 2, 9, 1, 3, 6};
        Sort(array, 0, array.Length - 1);

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}
