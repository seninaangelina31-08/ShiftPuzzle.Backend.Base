namespace prac1;
class Program
{
    static void Main(string[] args)
    {   
        int sumi = 0;
        int[] a = {0, 1, 2, 3, 4};
        foreach (int i in a)
        {
            sumi += i;
        }
        Console.WriteLine(sumi);
    }
}
