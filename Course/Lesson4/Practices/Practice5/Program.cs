namespace Practice5;
class Program
{
    static void Main(string[] args)
    {
        int[] array_negatives = {3, 2, 5, -2, 21, -4, -6, -3254};
        int counterA = 0;
        for (int i = 0; i < array_negatives.Length; i++){
            if (array_negatives[i] < 0){
                counterA++;
            } 
        }
        Console.WriteLine($"Количество отрицательных элементов: {counterA}");
    }
}
