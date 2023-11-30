namespace Practice4;
class Program
{
    static void Main(string[] args)
    {
        int[] array_evens = {1, 2, 12, 3, 4, 34, 5, 6, 56};
        Console.WriteLine($"Все четные числа:");
        for (int i = 0; i < array_evens.Length; i++){
            if (array_evens[i] % 2 == 0){
                Console.WriteLine(array_evens[i]);
            }
        }
    }
}
