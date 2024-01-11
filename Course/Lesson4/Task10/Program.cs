namespace Task10;

class Program
{
    static void Main(string[] args)
    {
        int[] array = {0, -3, 4, -2, 12, 99, -100, 8, -68, -111, 897, -21};
        for (int i=0; i<array.Length; ++i)
        {
            if (array[i]<0)
            {
                array[i] = 0;
            }
            Console.Write($"{array[i]} ");
        }
        
    }
}
