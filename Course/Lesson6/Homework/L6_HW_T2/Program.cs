namespace L6_HW_T2;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new();

        Console.WriteLine("Введите размер матрицы");
        int matrixSize = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Введите размер элементов матрицы");
        int arrayInMatrixSize = Convert.ToInt16(Console.ReadLine());

        int[,] matrix = new int[matrixSize, arrayInMatrixSize];
        int[,] result = new int[arrayInMatrixSize, matrixSize];

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < arrayInMatrixSize; j++)
            {
                matrix[i, j] = i * j;
            }
        }

        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = 0; j < arrayInMatrixSize; j++)
            {   
                result[j, i] = matrix[i, j];
            }
        }


        // вывод
        for (int i = 0; i < matrixSize; i++)
        {
            string numsStr = "{";
            for (int j = 0; j < arrayInMatrixSize; j++)
            {
                numsStr += $"{matrix[i, j]}, ";
            }
            Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
        }

        Console.WriteLine();

        for (int i = 0; i < arrayInMatrixSize; i++)
        {
            string numsStr = "{";
            for (int j = 0; j < matrixSize; j++)
            {
                numsStr += $"{result[i, j]}, ";
            }
            Console.WriteLine(numsStr.Substring(0, numsStr.Length - 2) + "}");
        }
    }
}
