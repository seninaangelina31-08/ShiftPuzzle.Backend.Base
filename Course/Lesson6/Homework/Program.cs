namespace Homework;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"1 Задача:");
        int[] numbers = { 1, 2, 3, 4, 5, 4, 5, 4 };
        int max_cnt = 0;
        int often_number = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < numbers.Length; j++)
            {
                if (numbers[i] == numbers[j])
                {
                    count++;
                }
            }

            if (count > max_cnt)
            {
                max_cnt = count;
                often_number = numbers[i];
            }
        }

        Console.WriteLine($"Число: {often_number}. Кол-во раз: {max_cnt}");

        Console.WriteLine($"2 Задача:");
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        int[,] transposedMatrix = TransposeMatrix(matrix);
        PrintMatrix(transposedMatrix);
    }

    static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposed = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposed[j, i] = matrix[i, j];
            }
        }
        return transposed;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
