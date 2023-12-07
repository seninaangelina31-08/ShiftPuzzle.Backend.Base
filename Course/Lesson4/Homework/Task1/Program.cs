namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        int[] array_1 = {1, 2, 3, 4, 5, 6};
        int[] array_2 = {4, 5, 6, 7, 8, 9};

        int[] merged_array = new int[array_1.Length + array_2.Length];

        int n = 0;
        Console.WriteLine("Исходный массив 1: ");
        foreach (int el in array_1)
        {
            merged_array[n] = el;
            n++;
            Console.Write(el + " ");
        }
        Console.WriteLine("\nИсходный массив 2: ");
        foreach (int el in array_2)
        {
            merged_array[n] = el;
            n++;
            Console.Write(el + " ");            
        }  

        Console.WriteLine("\nСлитый массив: ");
        foreach (int el in merged_array)
        {
            Console.Write(el + " ");            
        }
    }
}
