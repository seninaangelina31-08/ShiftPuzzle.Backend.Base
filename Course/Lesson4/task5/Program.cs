namespace task5;

class Program
{
    static void Main()
    {
        int number = 0;
        int[] array = {1, -2, -3, 4};
        foreach(int i in array)
        {
            if (i < 0)
            {
                number += 1;
            }
        }
        Console.WriteLine(number);
    }
}
