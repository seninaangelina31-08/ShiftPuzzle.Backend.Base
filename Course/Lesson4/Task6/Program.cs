namespace Task6;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 2, 3, 4, 5};
        int n = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == n) {
                Console.WriteLine(i);
                break;
            }
            
        }
    }
}
