namespace Task5;
class Program
//5. **Подсчет отрицательных чисел**
//   _Напишите программу для подсчета количества отрицательных чисел в массиве._

{
    static void Main(string[] args)
    {
        int[] array_1 = {-2, -1, 0, 1, 2, 3};
        int array_not_plus = 0;
        foreach(int number in array_1)
        {
            if (number < 0)
            {
                array_not_plus++;
            }
        }
        Console.WriteLine(array_not_plus);
    }
}
