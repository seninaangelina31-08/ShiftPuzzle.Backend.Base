namespace task7;

class Program
{
    static void Main(string[] args)
    {
        int[] lst = {1, 2, 3, 4, 5};

        for (int i = 0; i < lst.Length; i++){
            if (i % 2 == 1) {
                Console.WriteLine(lst[i]);
            }
        }
    }
}
