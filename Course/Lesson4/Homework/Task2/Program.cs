namespace task2;

class Program
{
    static void Main(string[] args)
    {
        int[] mas = {1, 2, 3, 4, 5};

        int[] new_mas = new int[mas.Length];

        int k = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < mas.Length; i++) {
            if (i < mas.Length - k){
                new_mas[i+k] = mas[i];
            }
            else {
            new_mas[i + k - mas.Length] = mas[i];
            }
        }

        foreach (int a in mas) {
            Console.Write($"{a} ");
        }
        Console.Write("\n");
        foreach (int a in new_mas) {
            Console.Write($"{a} ");
        }
    }
}
