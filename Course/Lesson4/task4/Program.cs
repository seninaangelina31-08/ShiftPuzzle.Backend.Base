namespace task4;

class Program
{
    static void Main()
    {
        int[] array = {1, 2, 3, 4};
        foreach(int i in array)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
