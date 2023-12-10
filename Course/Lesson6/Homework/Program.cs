// // Задание 1
// int chasto(int[] array)
// {
//     int count = 0;
//     int max = 0;
//     int max_number = 0;
//     foreach (int arr in array)
//     {
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (arr == array[i])
//             {
//                 count++;
//             }
//         }
//         if (count > max)
//         {
//             max = count;
//             max_number = arr;
//         }
//         count = 0;
//     }
//     return max_number;
// }
// int[] array = {1, 2, 1, 2, 1, 3, 3, 5, 5, 5, 5, 5, 1, 1};
// Console.WriteLine(chasto(array));

// Задание 2
int[,] transportirovanie(int[,] array)
{
    int[,] array_01 = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array_01[j, i] = array[i, j];
        }
    }
    return array_01;
}
int[,] matrix = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
matrix = transportirovanie(matrix);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}