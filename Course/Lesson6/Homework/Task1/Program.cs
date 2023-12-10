namespace Task1;

class Program
{
    public static int Count(int[] array)
    {
        int max_el = array[0];
        int max_count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == array[i])
                {
                    count++;
                }
            }
            if (max_count < count)
            {
                max_count = count;
                max_el = array[i];
            }
        }
        
        return max_el;
    }
    static void Main(string[] args)
    {  
        int[] b = {1, 2, 3, 1, 3, 3, 3, 2, 1, 2, 2};
        int a = Count(b);
        Console.Write(a); 
    }
}
