namespace Task5;
class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6};
        int numMinus = 0;
        foreach(num in a)
        {
            if(num < 0)
            {
                numMinus ++;
            }
        }
    }
}
