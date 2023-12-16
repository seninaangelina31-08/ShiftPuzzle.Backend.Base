namespace home2;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int rotations = 2;

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }

        RotateArrayRight(array, rotations);

        Console.WriteLine("\nПосле циклической ротации:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }

    static void RotateArrayRight(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n;

        int[] rotated = new int[n];

        for (int i = 0; i < n; i++)
        {
            rotated[(i + k) % n] = arr[i];
        }

        Array.Copy(rotated, arr, n);
    }
}