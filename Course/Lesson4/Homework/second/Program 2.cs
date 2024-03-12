namespace second;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array = new int[10];
        int k = 3;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 11);
        }

        Console.WriteLine("Исходный массив: " + string.Join(", ", array));

        int[] b = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {   
            if (i + k >= array.Length)
            {
                b[(i + k) - array.Length] = array[i];
            } else
            {
                b[i + k] = array[i];
            }
        }

        Console.WriteLine("Измененный массив: " + string.Join(", ", b));
    
    }
}
