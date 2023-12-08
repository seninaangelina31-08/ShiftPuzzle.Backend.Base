namespace Homework;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("1 ЗАДАНИЕ: ");
        int[] array1 = { -1, 2, 3, 4 };
        int[] array2 = { -5, 6 };

        int[] joined_array = new int[array1.Length + array2.Length];

        for (int i = 0; i < array1.Length; i++)
        {
            joined_array[i] = array1[i];
        }

        for (int i = 0; i < array2.Length; i++)
        {
            joined_array[array1.Length + i] = array2[i];
        }

        Console.WriteLine("Итоговый массив: ");
        for (int i = 0; i < joined_array.Length; i++)
        {
            Console.WriteLine(joined_array[i]);
        }



        Console.WriteLine("2 ЗАДАНИЕ: ");
        int[] array = { 1, 2, 3, 4, 5 };
        int k = 2;

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        int[] g = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {
            g[(i + k) % array.Length] = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = g[i];
        }

        Console.WriteLine("Измененный массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}