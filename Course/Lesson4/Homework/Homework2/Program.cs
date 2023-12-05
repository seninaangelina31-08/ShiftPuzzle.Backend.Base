namespace Homework2;
class Program
{
    static void Main(string[] args)
    {
        int[] array_nums = {1, 2, 3, 4, 5};
            int[] array_nums_copy = new int [array_nums.Length];
            int K = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(string.Join(",", array_nums));
            int[] array_new = array_nums[(array_nums.Length - K)..array_nums.Length];

            for (int i = 0; (i + K) < array_nums.Length; i++)
            {
                array_nums_copy[i + K] = array_nums[i];
            }

            for (int i = 0; i < array_new.Length; i++)
            {
                array_nums_copy[i] = array_new[i];
            }
            Console.WriteLine(string.Join(",", array_nums_copy));
    }
}
