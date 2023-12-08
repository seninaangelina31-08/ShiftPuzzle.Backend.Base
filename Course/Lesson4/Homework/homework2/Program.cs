 namespace homework2;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int rotations = 2;

        RotateArray(arr, rotations);

        Console.WriteLine("Rotated array:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    static void RotateArray(int[] arr, int rotations)
    {
        int length = arr.Length;

        int[] temp = new int[length];
        for (int i = 0; i < length; i++)
        {
            temp[(i + rotations) % length] = arr[i];
        }

        for (int i = 0; i < length; i++)
        {
            arr[i] = temp[i];
        }
    }
}