namespace Practice2;
class Program
{
    static void Main(string[] args)
    {
        int[] array_max = {1, 25, 81, 36, 64, 196, 144};
        int max_num = 0;
        for (int i = 0; i < array_max.Length; i++){
            if (array_max[i] > max_num){
                max_num = array_max[i];
            }
        }
        Console.WriteLine($"Максимальное число в массиве: {max_num}");
    }
}
