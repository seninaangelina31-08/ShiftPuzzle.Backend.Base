namespace hw1;

public class Class1
{
    static void Main(string[] args)
    {
        int[] array1 = { 1, 2, 3, 4 };
        int[] array2 = { 5, 6, 7, 8 };

        int[] array3 = new int[array1.Length + array2.Length];

        Array.Copy(array1, array3, array1.Length);
        Array.Copy(array2, 0, array3, array1.Length, array2.Length);

        Console.WriteLine(String.Join(" ",array3));
    }
}
