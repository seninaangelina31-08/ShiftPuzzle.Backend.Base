// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("M: ");
            int M = int.Parse(Console.ReadLine());
            Console.WriteLine("\nИсходная матрица: \n");
            int[,] A = new int[N, M];
            Random rnd = new Random();
 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    A[i, j] = rnd.Next(-20, 20);
                    Console.Write(A[i, j] + " \t ");
                }
                Console.WriteLine();
            }
            int[,] AT = new int[M, N];
            Console.WriteLine("\nТранспонированная матрица: ");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    AT[i, j] = A[j, i];
                    Console.Write(AT[i, j] + " \t ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
    }
}
