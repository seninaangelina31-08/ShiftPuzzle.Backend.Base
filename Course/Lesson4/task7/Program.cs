namespace task7;

class Program
{
    static void Main(string[] args)

    {
        int[] arr = { 1, 2, 3, 5, 6, 7 };
        Console.WriteLine("Элементы на нечетных позициях:");
        for (int i = 1; i < arr.Length; i += 2)
        {
            Console.WriteLine(arr[i]);
        }
        }
}
  
