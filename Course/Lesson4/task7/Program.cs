namespace task7;

class Program
{
    static void Main()
    {
        int[] array = {1, 2, 3, 4,5};
        for(int i = 0; i < array.Length; i+=2)
        {
            Console.WriteLine(array[i]);
        }
    }
}
