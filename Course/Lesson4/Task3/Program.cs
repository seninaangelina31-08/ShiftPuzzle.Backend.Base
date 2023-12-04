using System.Globalization;

namespace task3;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {1, 2, 3, 4, 5};
        int[] nums_reverse = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++) {
            nums_reverse[i] = numbers[numbers.Length-i-1];
        }
        Console.Write("Перевернутый массив: ");
        foreach (int arr in nums_reverse) {
            Console.Write($"{arr} ");
        }

    }
}
