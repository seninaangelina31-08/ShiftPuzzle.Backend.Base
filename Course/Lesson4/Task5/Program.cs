namespace Task5;
class Program
{
    static void Main(string[] args)
    {
        int[] array = {1, 2, 3, 4, -5, -6, -6, 8, 0};
        int below_zero = 0;
        
        foreach (int el in array)
        {
            if (el < 0)
            {
                below_zero++;
            }
        }
        Console.WriteLine($"В массиве {below_zero} отрицательных чисел");
    }  
}
