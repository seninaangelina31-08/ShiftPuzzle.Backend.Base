namespace prac10;
class Program
{
    static void Main(string[] args)
    {
        int[] a = {0, 1, -2, -3, 4};
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] < 0)
            {
                a[i] = 0;
            }
        }
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
