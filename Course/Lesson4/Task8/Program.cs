namespace Task8;
class Program
//8. **Минимальное и максимальное значения**
//   _Напишите программу для нахождения минимального и максимального элементов в массиве._
{
    static void Main(string[] args)
    {
        int[] array_1 = {0, 2,4, -4};
        int max = array_1[0];
        int min = array_1[0];
        foreach(int temp in array_1)
        {
            if (max < temp)
            {
                max = temp;
            }
            if (min > temp)
            {
                min = temp;
            }
        }
        Console.WriteLine(max + " " + min);
    }
}
