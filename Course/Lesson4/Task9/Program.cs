namespace Task9;

class Program
{
    static void Main(string[] args)
    {
        int n = 0;
        int[] array = {100, 1000, 0, 54, -102, 977};
        for (int i = 0; i < array.Length; ++i)
        {
            for (int sort = 0; sort < array.Length - 1; ++sort)
            {
                if (array[sort]>array[sort+1])
                {
                    n = array[sort + 1];
                    array[sort + 1] = array[sort];
                    array[sort] = n;

                }
            }
            Console.Write($"{array[i]} ");
        }
        
        
    }
}
