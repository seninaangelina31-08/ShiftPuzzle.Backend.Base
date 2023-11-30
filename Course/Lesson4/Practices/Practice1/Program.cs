namespace Practice1;
class Program
{
    static void Main(string[] args)
    {
        int[] array_sum = {1, 2, 3, 4};
        int sum = 0;
        for (int i = 0; i < array_sum.Length; i++){
            sum += array_sum[i];
        }
        Console.WriteLine($"Сумма всех элементов: {sum}");
    }
}
