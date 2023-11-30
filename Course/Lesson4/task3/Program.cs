namespace task3;

class Program
{
    static void Main()
    {
        int[] array = {1, 2, 3};
        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            int temp = array[i];
            array[i] = array[length - 1 - i];
            array[length - 1 - i] = temp;
        }
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
    }
}
