namespace Task8;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};
        int maxx = 0, minn = 1000;
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] > maxx) {
                maxx = arr[i];
            }
            if (arr[i]<minn) {
                minn = arr[i];
            }
        }
        Console.WriteLine(maxx);
        Console.WriteLine(minn);
    }
}
