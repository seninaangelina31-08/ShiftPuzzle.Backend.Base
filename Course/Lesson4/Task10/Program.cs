namespace task10;

class Program
{
    static void Main(string[] args)
    {
        int[] mas = {1, 2, -1, 3, -2, 5, -100};

        for (int i = 0; i < mas.Length; i++) {
            if (mas[i] < 0) {
                mas[i] = 0;
            }
        }
        Console.WriteLine("Итоговый массив: ");
        foreach (int ar in mas) {
            Console.Write($"{ar} ");
        }
    }
}
