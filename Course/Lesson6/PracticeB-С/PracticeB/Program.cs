namespace PracticeB_С;

class Program
{

    public static int[] F(int[] x)
    {
        int[] array = x;
        int maxsum = int.MinValue;
        int start = 0;
        int end = 0;
        int sum = 0;
        int gr = -1;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
            
            if (sum > maxsum)
            {
                maxsum = sum;
                end = i;
                start = gr + 1;
            }

            if (sum < 0)
            {
                sum = 0;
                gr = i;
            }

        }   
        
        int[] new_arrray = new int[end - start + 1];
        int c = 0;
        for (int i = start; i <= end; i++)
        {
            new_arrray[c] = array[i];
            c++;
        }
        return new_arrray;


        
    }
    static void Main(string[] args)
    {
        int[] a = {1, 2, 3, -100, 3, 5};
        int[] b = F(a);
        foreach (int el in b)
        {
            Console.Write(el + " ");
        }
        
    }
}
