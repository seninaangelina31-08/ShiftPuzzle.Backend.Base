using System;

class Program
{
    static void Main()
    {
        
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        
        int[,] transposedMatrix = new int[cols, rows];

        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        
        Console.WriteLine("Транспонированная матрица:");
        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                Console.Write(transposedMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
