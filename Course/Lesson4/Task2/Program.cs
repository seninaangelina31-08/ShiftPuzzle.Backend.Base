namespace Task2;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};
        int maxx = 0;
        for (int i = 0; i < arr.Length-1; i++) {
            if (arr[i] > maxx) {
                maxx = arr[i];
            }
        }
        Console.WriteLine(maxx);
    }
}
