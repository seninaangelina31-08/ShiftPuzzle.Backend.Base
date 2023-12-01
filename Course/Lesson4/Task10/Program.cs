namespace Task10;
class Program
//10. **Замена элементов массива**
//    _Напишите программу, которая заменяет все отрицательные элементы в массиве нулями._

{
    static void Main(string[] args)
    {
        int[] array_1 = {-2, -1, 0, 1, 2, 3};
        for (int count = 0; count < array_1.Length; count++)
        {
            if (array_1[count] < 0)
            {
                array_1[count] = 0;
            }
        }
        foreach(int number in array_1)
        {
            Console.WriteLine(number);
        }
    }
}
