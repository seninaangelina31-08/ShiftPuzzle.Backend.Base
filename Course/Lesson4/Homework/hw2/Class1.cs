namespace hw2;

public class Class1
{
    static void Main(string[] args)
    {
        int[] array = {1, 2, 3, 4, 5};
        int k = 3;

        Console.WriteLine("Исходный массив: " + string.Join(", ", array));

        int[] array2 = new int[array.Length];

        for (int i = 0; i < array.Length; i++)
        {   
            if (i + k >= array.Length)
            {
                array2[(i + k) - array.Length] = array[i];
            } else
            {
                array2[i + k] = array[i];
            }
        }

        Console.WriteLine("Результат ротации: " + string.Join(", ", array2)); 
    
    }
}
