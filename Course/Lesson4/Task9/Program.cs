namespace task9;

class Program
{
    static void Main(string[] args)
    {
        int[] lst = {10, 20, 2, 65, 81, 9, 0, 31};
        int a;

        for (int i = 0; i < lst.Length; i++) {
            for (int j = 0; j < lst.Length - 1; j++) {
                if (lst[i] < lst[j]) {
                    a = lst[i];
                    lst[i] = lst[j];
                    lst[j] = a;
                }
            }
        }

        foreach (int ar in lst) {
            Console.Write($"{ar} ");
        }

    }
}
