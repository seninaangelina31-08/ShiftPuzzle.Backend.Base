namespace HomeworkA;

class Program
{
    static void Main(string[] args)
    {
        int[] array_nums = {1, 1, 2, 34, 23, 1, 2, 3, 1};
        Console.WriteLine(string.Join(", ", FindMax(array_nums)));
    }
    public static int[] FindMax(int[] array_nums){
        Array.Sort(array_nums);
        Console.WriteLine(string.Join(",", array_nums));
        int[] result = new int[2];
        int count = 1; 
        int max_count = 1;
        for (int i = 0; i < array_nums.Length - 1; i++){
            if (array_nums[i] == array_nums[i+1]){
                count++;
            }
            else{
                if (max_count < count)
                {
                    max_count = count;
                    result[0] = count;
                    result[1] = array_nums[i];
                    Console.WriteLine(count);
                }
                count = 1;
            }
        }
        return result;
    }
}
