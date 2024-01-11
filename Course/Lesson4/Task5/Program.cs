namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {-0, 0, -3, 4, -2, 12, 99, -100, 8, -68, -111, 897, -21};
        int count = 0;
        foreach (int arr in array)
        {
            if (arr<0)
            {
                count+=1;
            }
        }
        Console.WriteLine(count);
    }
}
