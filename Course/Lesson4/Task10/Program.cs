namespace Task10;
class Program
{
    static void Main(string[] args)
    {
        int[] a = {1, 2, 4, 5, 6};
        for(int i = 0; i < a.lengh; i ++)
        {
            a[i] = a[i] < 0? 0: a[i];
        }
    }
}
