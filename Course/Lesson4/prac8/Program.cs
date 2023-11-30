namespace prac8;
class Program
{
    static void Main(string[] args)
    {
        int[] a = {0, 1, 2, 3, 4};
        int maxi = a[0];
        int mini = a[0];
        foreach (int i in a)
        {
            if (i > maxi)
            {
                maxi = i;
            } else if (i < mini){
                mini = i;
            }
        }
        Console.WriteLine(maxi);
        Console.WriteLine(mini);
    }
}
