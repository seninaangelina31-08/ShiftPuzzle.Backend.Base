namespace prac6;
class Program
{
    static void Main(string[] args)
    {
        int b = 3;
        int[] a = {0, 1, 2, 3, 4};
        for (int i = 0; i < a.Length; i++)
        {
            if (i == b)
            {
                Console.WriteLine(i);
            }
        }
    }
}
