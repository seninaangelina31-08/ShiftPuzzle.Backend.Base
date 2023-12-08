 namespace homework1;

class Program
{
    static void Main(string[] args)
    {
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            
            for (int i = 0; i < arr1.Length; i++)
            {
                mergedArray[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                mergedArray[i + arr1.Length] = arr2[i];
            }
            Console.WriteLine("Объединенный массив:");
            foreach (int num in mergedArray)
            {
                Console.Write(num + " ");
            }
    } 
}
