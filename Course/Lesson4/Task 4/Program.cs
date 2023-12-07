namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        int[] massiv = {1,2,3,4,5,6,7,8};

        foreach(int i in massiv)
        {
        if (i % 2== 0)
        {
        Console.WriteLine(i);
        }
        }
    }
}
