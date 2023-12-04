namespace Task1;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};
        int cnt = 0;
        for (int i = 0; i < arr.Length; i++) {
            cnt += arr[i];
        }
        Console.WriteLine(cnt);
    }
}
