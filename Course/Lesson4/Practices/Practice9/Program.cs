namespace Practice9;
class Program
{
    static void Main(string[] args)
    {
        int[] array_sort = {2, 3, 1, 2, 7, 6};
        for (int i = 0; i < array_sort.Length; i++){
            for (int j = 0; j < array_sort.Length; j++){
                if (array_sort[i] < array_sort[j]){
                    int w = array_sort[i];
                    array_sort[i] = array_sort[j];
                    array_sort[j] = w;
                }
            }
        }
        Console.WriteLine($"Отсортированный массив: {string.Join(",", array_sort)}");
    }
}
