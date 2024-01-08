using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[] array = { 1, 2, 3, 4, 5 };

        
        int rotationCount = 2;

        RotateRight(array, rotationCount);

        
        Console.WriteLine("Результат ротации:");
        Console.WriteLine(string.Join(", ", array));
    }

    static void RotateRight(int[] array, int rotationCount)
    {
        rotationCount %= array.Length;

        int[] temp = new int[rotationCount];
        Array.Copy(array, array.Length - rotationCount, temp, 0, rotationCount);

        Array.Copy(array, 0, array, rotationCount, array.Length - rotationCount);

        Array.Copy(temp, 0, array, 0, rotationCount);
    }
}
