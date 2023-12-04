namespace Task3;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};
        int[] arr1 = new int[arr.Length];
        int cnt = 0;
        for (int i = arr.Length-1; i > -1; i--) {
            Console.WriteLine(arr[i]);
            arr1[arr.Length-i-1] = arr[i];
        }
        
    }
}
