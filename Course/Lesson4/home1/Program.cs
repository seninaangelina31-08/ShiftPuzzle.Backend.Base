namespace home1;

class Program
{
    static void Main(string[] args)
    {
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 6, 7, 8, 9, 10 };

        int[] mergedArray = new int[array1.Length + array2.Length];

        Array.Copy(array1, mergedArray, array1.Length);
        Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);

        Console.WriteLine("Объединенный массив:");
        
        foreach (int num in mergedArray)
        
        {
            Console.Write(num + " ");
        }
    }
}
}