namespace task5;

class Program
{
    static void Main(string[] args)
    {
        int[] lst = {-2, -1, 0, 1, 2};
        int c = 0;

        for (int i = 0; i < lst.Length; i++) {
            if (lst[i] < 0) {
                c += 1;
            }
        }
        Console.WriteLine(c);
    }
}
