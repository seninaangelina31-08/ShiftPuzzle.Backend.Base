namespace Task6;
class Program
{
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6};
        int searchNum = 3;
        for(int i = 0; i < a.lengh; i++)
        {
            if(a[i] == searchNum)
            {
                Console.WriteLine(i);
            }
        }
    }
}
