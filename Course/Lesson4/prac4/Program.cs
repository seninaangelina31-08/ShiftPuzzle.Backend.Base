namespace prac4;
class Program
{
    static void Main(string[] args)
    {
        int[] a = {0, 1, 2, 3, 4};
        foreach (int i in a)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
