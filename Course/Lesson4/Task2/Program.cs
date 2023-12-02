namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = {-1, -2, -3, -4, -5};
        int max = numbers[0];

        foreach(int i in numbers)
        {
            if(i > max)
            {
                max = i;
            }
        }
        Console.WriteLine(max);
    }
}
