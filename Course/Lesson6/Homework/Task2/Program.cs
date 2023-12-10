namespace Task2;

class Program
{
        public static int[,] Transpose(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);
    
        int[,] transposed_matrix = new int[columns, rows];
    
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                transposed_matrix[j, i] = matrix[i, j];
            }
        }   
        return transposed_matrix;         
    }
    
    public static void MatrixPrint(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {

        int[,] matrix = {
            {1, 2},
            {3, 4},
            {5, 6}
        };
        
        int[,] transposed_matrix = Transpose(matrix);

        Console.WriteLine("Исходная матрица: ");
        MatrixPrint(matrix);
        Console.WriteLine("\nТранспонированная матрица: ");
        MatrixPrint(transposed_matrix);
    
    }
}
