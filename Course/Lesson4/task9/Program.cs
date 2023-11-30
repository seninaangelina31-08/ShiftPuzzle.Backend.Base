namespace task9;

class Program
{
    static void Main()
    {
        int[] array = {5, 4, 3, 2, 1};
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
         foreach (int number in array)
        {
            Console.Write(number + " ");
        }
    }
}
