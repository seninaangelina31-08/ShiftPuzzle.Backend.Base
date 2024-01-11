namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {0, 3, 4, 2, 12, 99, 100, 8, 68, 111, 897, 21};
        foreach (int arr in array)
        {
            if (arr%2==0)
            {
                Console.WriteLine(arr);
            }
        }
        
    }
}
