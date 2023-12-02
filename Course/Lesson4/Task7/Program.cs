namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        //_Создайте программу для вывода элементов массива, которые находятся на нечетных позициях._
        int j=4;
        int[] numbers = {1,3,7,8,6};
        for (int i=1;  i < j; i+=2)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
