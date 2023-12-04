namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 2, 4, 6, 8 };
        Array.Reverse(array);
 
        Console.WriteLine(String.Join(',', array));
    }
}
