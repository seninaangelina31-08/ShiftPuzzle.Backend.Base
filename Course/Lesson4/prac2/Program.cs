namespace prac2;
class Program
{
    static void Main(string[] args)
    {
        int maxi = 0;
        int[] a = {0, 1, 2, 3, 4};
        foreach (int i in a)
        {
            if (i > maxi)
            {
                maxi = i;
            }
        }
        Console.WriteLine(maxi);
    }
}
