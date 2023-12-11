namespace Task2;
using System;

class Program {

    static void PrintMatrix(int[,] matrix, int rows, int columns) {


        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static void Main() {
        int rows = 3;    
        int columns = 3; 

        int[,] matrix = new int[3, 3] {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Исходная матрица:");
        PrintMatrix(matrix, rows, columns);

        int[,] transposedMatrix = TransposeMatrix(matrix, rows, columns);

        Console.WriteLine("Транспонированная матрица:");
        PrintMatrix(transposedMatrix, rows, columns);
    }

    static int[,] TransposeMatrix(int[,] matrix, int rows, int columns) {


        int[,] transposedMatrix = new int[columns, rows];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < columns; j++) {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }

        return transposedMatrix;
    }
}

