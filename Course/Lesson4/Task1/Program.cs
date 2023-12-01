namespace Task1;
class Program
//1. **Сумма элементов массива**
//  _Напишите программу для вычисления суммы всех элементов в массиве целых чисел._
{
    static void Main(string[] args)
    {
        int[] array_1 = {0, 2, 4};
        int sum = 0;
        foreach(int temp in array_1)
        {
            sum = sum + temp;
        }
        Console.WriteLine(sum);
    }
}
