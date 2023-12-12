namespace task1;

class Program
{
    static void Main(string[] args)
    {
        factor(7);
    }
    public static int factor(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        else{
            return n * factor(n - 1);
        }
    }
}
