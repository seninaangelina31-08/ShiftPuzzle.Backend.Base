namespace task4;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int sum = Sum(array, 0);
        Console.WriteLine("Сумма элементов массива: " + sum);
    }
    public static int Sum(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            return 0;
        }
        return arr[index] + Sum(arr, index + 1);
    }
}
