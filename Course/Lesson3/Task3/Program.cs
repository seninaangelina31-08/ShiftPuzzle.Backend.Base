namespace Task3;
class Program
/*3. **Доступ к элементу массива**
   _Создайте массив чисел и выведите второй элемент._
*/
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        numbers[1] = 5;
        Console.WriteLine(numbers[1]);
    }
}
