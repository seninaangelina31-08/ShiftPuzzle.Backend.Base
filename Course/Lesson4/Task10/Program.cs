namespace Task10;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {1, 2, -3, -4, -5, 6, 7, 8, -9};


        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = 0;
            }
        }
        Console.WriteLine($"Итоговый массив: ");
        foreach (int el in array)
        {
            Console.WriteLine(el);
        }
    }
}
