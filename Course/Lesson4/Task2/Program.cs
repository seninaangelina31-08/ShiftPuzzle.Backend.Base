namespace Task2;
class Program
//2. **Поиск максимального элемента**
//   _Создайте программу для нахождения максимального значения в массиве целых чисел._
{
    static void Main(string[] args)
    {
        int[] array_1 = {0, 2, 4};
        int max = array_1[0];
        foreach(int temp in array_1)
        {
            if (max < temp)
            {
                max = temp;
            }
        }
        Console.WriteLine(max);
    }
}
