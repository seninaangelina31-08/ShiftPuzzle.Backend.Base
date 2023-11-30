namespace prac3;
class Program
{
    static void Main(string[] args)
    {
        int[] a = {0, 1, 2, 3, 4};
        int[] b = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            b[5 - i - 1] = a[i];
        }
        
        for (int i = 0; i < b.Length; i++)
        {
            Console.WriteLine(b[i]);
        }
    }
}
