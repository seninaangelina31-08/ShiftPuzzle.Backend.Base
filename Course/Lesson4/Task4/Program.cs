namespace Task4;
//4. **Четные числа в массиве**
//   _Создайте программу, которая выводит все четные числа из заданного массива._

class Program
{
    static void Main(string[] args)
    {
        int[] array_1 = {0, 1, 2, 3, 4};
        foreach(int number in array_1)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }

    }
}
