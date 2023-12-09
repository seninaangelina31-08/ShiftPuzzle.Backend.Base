namespace HomeTask_2;

class Program
{
    static void Main(string[] args)
    {
         int[] arr = { 1, 2, 3, 4, 5 };
            int k = 3;
            int tmp;
            int per = 0;
 
            Console.WriteLine("Исходный массив: " + string.Join(" ", arr));
 
            for (int i = 0; i < arr.Length-1; ++i)
            {
                per += k;
                per %= arr.Length;
 
                tmp = arr[per];
                arr[per] = arr[0];
                arr[0] = tmp;
            }
 
            Console.WriteLine(string.Join(" ", arr));
    }
}
