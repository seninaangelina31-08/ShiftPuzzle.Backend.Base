namespace Task4;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] % 2 == 0) {
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
