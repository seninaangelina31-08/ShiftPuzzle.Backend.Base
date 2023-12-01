namespace task4;

class Program
{
    static void Main(string[] args)

    {
        int[] arr = {1, 2, 3, 4, 5};
        foreach (int x in arr)
        {
            if (x%2==0)
            {
                Console.WriteLine(x);
            }
        }
          
       
    }
}


