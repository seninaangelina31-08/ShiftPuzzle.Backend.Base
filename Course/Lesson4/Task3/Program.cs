using System.Globalization;

namespace task3;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1, 2, 3, 4, 5};
        int[] nums_reverse = new int[5];

        for (int i = numbers.Length - 1; i >= 0; i-=1) {
            nums_reverse.Add(numbers[i]);
        }

        foreach (int arr in nums_reverse) {
            Console.WriteLine(arr);
        }

    }
}
