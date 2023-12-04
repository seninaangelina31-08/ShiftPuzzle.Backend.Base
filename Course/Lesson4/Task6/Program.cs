namespace task6;

class Program
{
    static void Main(string[] args)
    {
        int[] mas = {1, 2, 3, 4, 5, 6};
        int element = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < mas.Length; i++) {
            if (element == mas[i]) {
                Console.WriteLine($"Индекс заданного элемента в списке: {i}");
            }
        }
    }
}
