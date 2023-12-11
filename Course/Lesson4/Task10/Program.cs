namespace Task10;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, -5, 7, -9, 0, -12, 15, -20 };

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                array[i] = 0;
            }
        }

        Console.WriteLine("Массив после замены отрицательных элементов нулями:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}