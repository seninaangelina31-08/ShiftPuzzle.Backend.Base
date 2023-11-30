namespace Practice8;
class Program
{
    static void Main(string[] args)
    {
        int[] array_border = {25, 1, 81, 36, 64, 196, 144};
        int max_num = array_border[0];
        int min_num = array_border[0];
        for (int i = 0; i < array_border.Length; i++){
            if (array_border[i] > max_num){
                max_num = array_border[i];
            }
            else if (array_border[i] < min_num){
                min_num = array_border[i];
            }
        }
        Console.WriteLine($"Минимальное число в массиве: {min_num}");
        Console.WriteLine($"Максимальное число в массиве: {max_num}");

    }
}
