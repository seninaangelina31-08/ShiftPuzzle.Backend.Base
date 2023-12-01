namespace Task7;
class Program
//7. **Вывод элементов на нечетных позициях**
//   _Создайте программу для вывода элементов массива, которые находятся на нечетных позициях._
{
    static void Main(string[] args)
    {
        int[] array_1 = {0, 2, 3, 4};
        for(int count = 0; count != array_1.Length; count = count + 2)
        {
            Console.WriteLine(array_1[count]);
        }
    }
}
