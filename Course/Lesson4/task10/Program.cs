namespace task10;

class Program
{
    static void Main()
    {
        int[] array = { 1, -2, 3, -4, 5 };

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = 0;
            }
        }
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}