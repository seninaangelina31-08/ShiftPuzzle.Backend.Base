using System;

class Program
{
    static void Main()
    {
        
        int[] arr = { 5, 2, 8, 1, 3 };

        
        Console.WriteLine("Неотсортированный массив:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        
        BubbleSort(arr);

        
        Console.WriteLine("\nОтсортированный массив:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }

        Console.ReadLine();
    }

    
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Обмен элементов
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
