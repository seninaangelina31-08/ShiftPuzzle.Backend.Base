namespace Ex2;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int[,] arr = new int[5,5];
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                arr[i,j] = rand.Next(0, 101);
        }
        Console.WriteLine("Матрица: ");
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                Console.Write($"{arr[i,j]} ");
            Console.WriteLine();
        }
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
            {
                if (i < j)
                {
                    int temp = arr[i,j];
                    arr[i,j] = arr[j, i];
                    arr[j,i] = temp;
                }
            }
        }
        Console.WriteLine("Транспонируемая матрица: ");
        for(int i = 0; i < arr.GetLength(0); i++)
        {
            for(int j = 0; j < arr.GetLength(1); j++)
                Console.Write($"{arr[i,j]} ");
            Console.WriteLine();
        }
    }
}
