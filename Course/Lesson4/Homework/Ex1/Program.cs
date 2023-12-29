namespace Ex1;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[] arr = new int[5];
        int[] arr2 = new int[5];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 51);
        }
        for(int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = rand.Next(50, 101);
        }
        int[] arr3 = new int[arr2.Length + arr.Length];
        for(int i = 0; i < arr3.Length; i++)
        {
            if (i < arr.Length)
            {
                arr3[i] = arr[i];
            }
            else if (i < arr3.Length)
            {
                arr3[i] = arr2[i - arr.Length];
            }
        }
        Console.WriteLine(String.Join(", ", arr3));
    }
}
