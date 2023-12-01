namespace Task9;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {123, 1, 92, 812, -1123};

        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        foreach(int el in array)
        {
            Console.WriteLine(el);
        }
    }
}
