namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {1, 2, 3, 4, 5};
        int k = 2;
        int[] rotated_array = new int[array.Length];

        Console.WriteLine("Исходный массив: ");
        
        foreach (int el in array)
        {
            Console.Write(el + " ");
        }

        for (int i = 0; i < array.Length; i++)
        {
            rotated_array[(i + k) % array.Length] = array[i];
        }

        Console.WriteLine("\nРезультат: ");
        foreach (int el in rotated_array)
        {
            Console.Write(el + " ");
        }
    }

}
