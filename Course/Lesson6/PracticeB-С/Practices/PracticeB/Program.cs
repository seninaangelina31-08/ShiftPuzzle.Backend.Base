namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {
        int[] array_nums = {1, 3, 5, 2, 4, 6, 3};
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(string.Join(",", MaxSum(a, array_nums)));
    }

    public static int[] MaxSum(int a, int[] list){
        int[] array_max_sum = new int[a];
        Array.Sort(list);
        Array.Reverse(list);
        for (int i = 0; i < a; i++){
            array_max_sum[i] = list[i];
        }
        return array_max_sum;
    }
}
