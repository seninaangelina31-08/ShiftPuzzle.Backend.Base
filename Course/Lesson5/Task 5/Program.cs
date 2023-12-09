using System;
using System.Linq;
namespace Task_5;
class Program

{
    static void Main(string[] args)
    {
    int[] array1 = {1, 2, 3, 4 ,5};
    int[] array2 = {5, 6, 7, 8, 9, 1};
    int[] result = array1.Concat(array2).ToArray();
    int[] distinct = result.Distinct().ToArray();

    Console.WriteLine(string.Join(" ", distinct));
    }
}
