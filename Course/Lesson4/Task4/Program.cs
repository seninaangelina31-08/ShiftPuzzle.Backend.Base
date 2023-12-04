namespace task4;

class Program
{
    static void Main(string[] args)
    {
        int[] lst = {1, 2, 3, 4, 5};
        for (int i = 0; i < lst.Length; i++) {
            if (lst[i] % 2 == 0) {
                Console.WriteLine(lst[i]);
            }
        }
    }
}
