namespace HomeTask_1;

class Program
{
    static void Main(string[] args)
    {
    int[] array1 = {1, 2, 3, 4 ,5};
    int[] array2 = { 6, 7, 8, 9, 10};
    int[] result = array1.Concat(array2).ToArray();
    Console.WriteLine(string.Join(" ", result));
    }
}
