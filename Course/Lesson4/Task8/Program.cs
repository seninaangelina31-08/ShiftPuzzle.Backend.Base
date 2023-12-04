namespace task8;

class Program
{
    static void Main(string[] args)
    {
        int[] lst = {1, 2, 3, 4, 5};
        int min = lst[0];
        int max = lst[0];

        for (int i = 0; i < lst.Length; i++) {
            if (min > lst[i]) {
                min = lst[i];
            }
            if (max < lst[i]) {
                max = lst[i];
            }
        }
        Console.WriteLine($"Max element: {max} \nMin element: {min}");
    }
}
