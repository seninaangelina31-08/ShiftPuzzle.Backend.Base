namespace second;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Console.Write("M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nИсходная матрица: \n");
        int[,] array = new int[N, M];
        Random rnd = new Random();

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                array[i, j] = rnd.Next(-20, 20);
                Console.Write(array[i, j] + " \t ");
            }
            Console.WriteLine();
        }
        int[,] array_T = new int[M, N];
        Console.WriteLine("\nТранспонированная матрица:\n");
        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                array_T[i, j] = array[j, i];
                Console.Write(array_T[i, j] + " \t ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
