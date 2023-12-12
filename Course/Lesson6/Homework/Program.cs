// task1

void FrequentElement(int[] arr)
{
    int maxCount = 0;
    int[] counts = new int[arr.Max()+1];

    for (int i = 0; i < arr.Length; i++)
    {
        counts[arr[i]]++;
        if (counts[arr[i]] > maxCount)
        {
            maxCount = counts[arr[i]];
        }
    }

    for (int i = 0; i < counts.Length; i++)
    {
        if (counts[i] == maxCount)
        {
            Console.WriteLine($"Число {i} встречается {maxCount} раз(а)");
        }
    }
}

int[] array = {42, 7, 5, 5, 51, 25, 58, 11, 7, 13, 4, 5, 23, 7, 56, 5, 7};

FrequentElement(array);

// task 2

void TransposeMatrix(int[,] mtrx)
{
    int rows = mtrx.GetLength(0);
    int cols = mtrx.GetLength(1);
    int[,] transposed = new int[cols, rows];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            transposed[j, i] = mtrx[i, j];
        }
    }

    for (int i = 0; i < transposed.GetLength(0); i++)
    {
        for (int j = 0; j < transposed.GetLength(1); j++)
        {
            Console.Write(transposed[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[,] 
{ 
    { 1, 2, 3 }, 
    { 4, 5, 6 }, 
    { 7, 8, 9 } 
};

TransposeMatrix(matrix);