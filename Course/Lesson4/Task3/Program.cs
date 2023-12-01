namespace Task3;

class Program
{
    static void Main(string[] args)
    {   
        int[] array = {1, 2, 3, 4};
        int[] reversed_array = new int[array.Length];
        int k = 0;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            reversed_array[k] = array[i];
            k ++;
        }

        Console.WriteLine("Развернутый массив: ");
        
        foreach (int el in reversed_array)
        {
            Console.WriteLine($"{el} ");
        }
        
    }

}
