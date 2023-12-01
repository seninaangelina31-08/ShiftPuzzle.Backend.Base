namespace task9;

class Program
{
    static void Main(string[] args)
    {
        
        int[] arr = { -1, 2, 3, -4, -5 };
        int c = 0;
        for (int i = 0; i < arr.Length; i++) {
            for (int j = 0; j < arr.Length - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    c = arr[j + 1];
                    arr[j + 1] = arr[j];
                    arr[j] = c;
                }
            }
        }
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }

}