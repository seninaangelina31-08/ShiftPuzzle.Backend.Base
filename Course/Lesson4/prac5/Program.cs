namespace prac5;
class Program
{
    static void Main(string[] args)
    {
        int cnt = 0;
        int[] a = {0, 1, 2, 3, 4};
        foreach (int i in a)
        {
            if (i < 0)
            {
                cnt ++;
            }
        }
        Console.WriteLine(cnt);
    }
}
