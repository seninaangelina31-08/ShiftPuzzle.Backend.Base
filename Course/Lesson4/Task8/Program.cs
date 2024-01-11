namespace Task8;

class Program
{
    static void Main(string[] args)
    {
        int Max = -99999999;
        int Min = 999999999;
        int[] array = {100, 1000, 0, 54, -102, 9, 8, 8, 77};
        for (int i = 0; i < array.Length; ++i)
        {
            if (Max < array[i])
            {
                Max = array[i];
            }
            if (Min > array[i])
            {
                Min = array[i];
            }
        }
        Console.WriteLine($"Максимальное = {Max}, минимальное = {Min}");
    }
}
