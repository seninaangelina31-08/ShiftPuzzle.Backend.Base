using System;

class Program
{
    static void Main()
    {
        
        int[] arr = { 1, 2, 3, 4, 5 };

       
        arr[2] = 100;

        
        Console.WriteLine("Массив после изменения:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}