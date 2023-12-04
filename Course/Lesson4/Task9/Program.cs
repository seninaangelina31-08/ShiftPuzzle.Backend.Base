namespace Task9;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 4, 3, 2, 1};
        int temp = 0;
        for (int w = 0; w < arr.Length; w++) {
            for (int s = 0; s < arr.Length - 1; s++) {
                if (arr[s] > arr[s + 1]) {
                    temp = arr[s + 1];
                    arr[s + 1] = arr[s];
                    arr[s] = temp;
                }
            }
        }
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
    }
}
