using System;

namespace htask1;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers1 = {1, 2, 3, 4, 5};
        int[] numbers2 = {6, 7, 8, 8, 9};

        int[] numbers = new int[numbers1.Length + numbers2.Length];
        Array.Copy(numbers1,numbers,numbers1.Length);
        Array.Copy(numbers2, 0, numbers,numbers1.Length,numbers2.Length);
        foreach(int num in numbers){
            System.Console.WriteLine(num+" ");
        }

    }
}
