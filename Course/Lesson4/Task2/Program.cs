namespace Task2;

class Program
{
    static void Main(string[] args)
    {
       int SearchMax = 0;
       int[] array = {100, 1000, 0, 54, -102, 9, 8, 8, 77};
       for (int i = 0; i < array.Length; ++i)
        {
            if (SearchMax < array[i])
            {
                SearchMax = array[i];
            }
        }
        Console.WriteLine(SearchMax);
    }
}
