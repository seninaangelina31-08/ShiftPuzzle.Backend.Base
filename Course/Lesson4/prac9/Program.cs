namespace prac9;
class Program
{
    static void Main(string[] args)
    {
        int[] a = {0, 2, 3, 4, 1};
        int len = a.Length;
        for (var i = 1; i < len; i++)
        {
            for (var j = 0; j < len - i; j++)
            {
                if (a[j] > a[j + 1])
                {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
    }
}
