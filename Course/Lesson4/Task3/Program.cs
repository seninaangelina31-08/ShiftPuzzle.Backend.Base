namespace Task3;
class Program
//3. **Обратный порядок массива**
//   _Напишите программу, которая переворачивает массив (последний элемент становится первым, и так далее)._

{
    static void Main(string[] args)
    {
        int[] array_1 = {0, 1, 4, 5};
        int[] temp_array_1 = new int[array_1.Length];
        for (int count = array_1.Length - 1; count >=0; --count)
        {
            temp_array_1[count] = array_1[array_1.Length - count -1];
        }
        foreach(int temp in temp_array_1)
        {
            Console.WriteLine(temp);
        }
    }
}
