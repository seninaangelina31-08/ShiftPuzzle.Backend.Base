namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        int summ = 0;
        int[] array = {1, 2, 3, 4, 5};
        for (int i = 0; i < array.Length; ++i)
        {
            summ = summ+ array[i];
        }
        Console.WriteLine(summ);
    }
}