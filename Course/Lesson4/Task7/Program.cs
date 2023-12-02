namespace Task7;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, -2, 3, 4, -5 };
        Console.WriteLine("Элементики на нечетных позициях:");

        for (int i = 1; i < arr.Length; i += 2)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
