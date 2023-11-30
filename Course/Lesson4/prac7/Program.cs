namespace prac7;
class Program
{
    static void Main(string[] args)
    {
        int[] a = {0, 1, 2, 3, 4};
        for (int i = 0; i < a.Length; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
