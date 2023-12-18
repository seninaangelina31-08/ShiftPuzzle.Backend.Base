// Практика B
int[] array = {10, 1, 2, 3, 4, 5, 6};
Console.Write("Введите размер подмассива: ");
int k = Convert.ToInt32(Console.ReadLine());
int[] Max_pos(int[] array, int k)
{
    int[] array_1 = new int[k];
    int[] array_2 = new int[k];
    for (int i = 0; (i + k - 1) < array.Length; i++)
    {
        for (int j = 0; (i+j) <= (i + k - 1); j++)
        {
            array_1[j] = array[i + j];
        }
        if (array_1.Sum() > array_2.Sum())
        {
            for (int h = 0; h < array_1.Length; h++)
            {
                array_2[h] = array_1[h];
            }
        }
    }
    return array_2;
}
int[] array_test = Max_pos(array, k);
foreach (int arr in array_test)
{
    Console.WriteLine(arr);
}

// // Практика C
// int[] array = {1, 2, 3};
// int l = array.Length;
// int[] level = new int[l];
// for (int i = 0; i < level.Length; i++)
// {
//     level[i] = 0;
// }
// void Variation(int[] array)
// {
//     if (level[l - 1] == l)
//     {
//         level[l - 2]++;
//     }
//     else
// }
