namespace task1;

class Program
{
    static void Main(string[] args)
    {
        int[] mas_1 = {1, 2, 3, 4, 5};
        int[] mas_2 = {1, 2, 3, 4, 5};

        int[] ans = new int[mas_1.Length + mas_2.Length];

        for (int i = 0; i < mas_1.Length; i++) {
            ans[i] = mas_1[i];
            ans[i + mas_2.Length] = mas_2[i];
        }
        Console.Write("Итоговый массив: ");
        foreach (int ar in ans) {
            Console.Write($"{ar} ");
        }
    }
}
