namespace Task9;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 2, 7, 1, 9, 3 };

        Console.WriteLine("Отсортированный массив по возрастанию:");
        Array.Sort(array);

        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}