namespace Task9;
class Program
//9. **Сортировка массива**
//   _Реализуйте сортировку массива по возрастанию (любым методом сортировки)._
{
    static void Main(string[] args)
    {
        int[] array_1 = {0, 1, 2, 4, 3, 0, 213, 12, 12, 444, 22, 11,  333, 44, 123};
        int temp_c = 0;
        for (int temp_1 = 1; temp_1 != array_1.Length + 1; temp_1++)
        {
            for (int temp_2 = array_1.Length - 1; temp_2 >=1; temp_2--)
            {
                if (array_1[temp_2] < array_1[temp_2 - 1])
                {
                    temp_c = array_1[temp_2];
                    array_1[temp_2] = array_1[temp_2 - 1];
                    array_1[temp_2 - 1] = temp_c;
                }
            }
        }
    foreach(int count in array_1)
    {
        Console.WriteLine(count);
    }
    }
}
