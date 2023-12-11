using System;
namespace htask2;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int rotationCount = 2;

        RotateArray(numbers, rotationCount);

        Console.WriteLine("Результат: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    static void RotateArray(int[] array, int rotationCount)
    {
        int length = array.Length;
        rotationCount = rotationCount % length;
        int[] tempArray = new int[rotationCount];
        Array.Copy(array, length - rotationCount, tempArray, 0, rotationCount);
        Array.Copy(array, 0, array, rotationCount, length - rotationCount);
        Array.Copy(tempArray, array, rotationCount); 
    }
}
