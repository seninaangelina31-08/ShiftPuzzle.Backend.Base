namespace Task4;
class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6};
        foreach(num in a)
        {
            if(num % 2 == 1)
            {
                Console.WriteLine(num);
            }
        }
    }
}
