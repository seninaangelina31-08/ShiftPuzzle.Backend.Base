namespace Practice10;
class Program
{
    static void Main(string[] args)
    {
        int[] array_nulls = {-1, -2, 3, 4, -5, -6, 7, 8};
        for (int i = 0; i < array_nulls.Length; i++){
            if (array_nulls[i] < 0){
                array_nulls[i] = 0;
            }
        }
        Console.WriteLine($"Измененный массив: {string.Join(",", array_nulls)}");
    }
}
