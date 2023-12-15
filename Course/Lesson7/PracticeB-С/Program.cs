
string Labirint(int[,] lab, int x1, int y1, int[] array)
{
    if(lab[y1, x1] == 0)
    {
        if ((lab[(y1 - 1), x1] == 0 || lab[(y1 - 1), x1] == 2) && array[array.Length - 1] != 1) {
            lab[y1, x1] = 1;
            y1 -= 1;
            return "Вверх " + Labirint(lab, x1, y1, array);
            
            }
        else if ((lab[y1, (x1 + 1)] == 0 || lab[y1, (x1 + 1)] == 2)  && array[array.Length - 1] != 2) {
            lab[y1, x1] = 1;
            x1 += 1;
            return "Вправо " + Labirint(lab, x1, y1, array);
            }
        else if ((lab[(y1 + 1), x1] == 0 || lab[(y1 + 1), x1] == 2) && array[array.Length - 1] != 3) {
            lab[y1, x1] = 1;
            y1 += 1;
            return "Вниз " + Labirint(lab, x1, y1, array);
            }
        else if ((lab[y1, (x1 - 1)] == 0 || lab[y1, (x1 - 1)] == 2)  && array[array.Length - 1] != 2) {
            lab[y1, x1] = 1;
            x1 -= 1;
            return "Влево " + Labirint(lab, x1, y1, array);
            }
        else {return "Нет пути.";}
    }
    else
    {
        return "Финиш!";
    }
}
// int[,] lab = {  {1, 1, 1, 1, 1},
//                 {1, 2, 1, 1, 1},
//                 {1, 0, 0, 0, 1},
//                 {1, 1, 1, 1, 1}};
// int[] array = {0};
// Console.WriteLine(Labirint(lab, 3, 2, array));

int[] QuickSort(int[] array, int i_end = 0)
{
    i_end = array.Length - 1;
    int[] Sort(int[] array,  int i_end, int i = 0, int z = 0)
    {
        if (i_end != 0)
        {
            if (i < i_end)
            {
                if (array[i_end] < array[i])
                {
                    z = array[i_end];
                    array[i_end] = array[i];
                    array[i] = z;
                }
                i++;
            }
            else
            {
                i = 0;
                i_end--;
            }
            return Sort(array, i_end, i);
        }
        else
        {
            return array;
        }
    }
    return Sort(array, i_end);
}
// int[] array = {7, 9, 1, 3, 4, 2, 5, 8, 6, 7};
// Console.WriteLine(String.Join(", ", QuickSort(array)));

int Min_derevo(string[][] derevo, int level = 0, int min = 0)
{
    bool IsDigitsOnly(string str)
    {
        foreach (char c in str)
        {
            if (c < '0' || c > '9') return false;
        }
        return true;
    }
    if (level == 0)
    {
        min = Convert.ToInt32(derevo[0][0]);
        level++;
        return Min_derevo(derevo, level, min);
    }
    else
    {
        if (IsDigitsOnly(derevo[level][0]))
        {
            min = Convert.ToInt32(derevo[level][0]);
            level++;
            return Min_derevo(derevo, level, min);
        }
        else
        {
            return min;
        }
    }
    
}
string[][] derevo = [["53"], ["23", "68"], ["20", "26", "N", "74"], ["N", "N", "22", "N", "N", "91"]];
// Console.WriteLine(Min_derevo(derevo));

// int Bin_search(int[] array, int target, int[] index)
// {
//     if (index.Length == 0) {
//         Array.Resize(ref index, array.Length);
//         for (int i = 0; i < array.Length; i++) {
//             index[i] = i + 1;
//         }
//     }
//     if (array.Length > 1) {
//         if (array.Length % 2 == 0) {
//             if (array[array.Length / 2 - 1] >= target) {
//                 return Bin_search(array[0..(array.Length / 2 - 1)], target, index[0..(array.Length / 2 - 1)]);
//             }
//             else {
//                 return Bin_search(array[(array.Length / 2)..(array.Length - 1)], target, index[(array.Length / 2)..(array.Length - 1)]);
//             }
//         }
//         else {
//             if (array[array.Length / 2] >= target) {
//                 return Bin_search(array[0..(array.Length / 2)], target, index[0..(array.Length / 2)]);
//             }
//             else {
//                 return Bin_search(array[(array.Length / 2 + 1)..(array.Length - 1)], target, index[(array.Length / 2 + 1)..(array.Length - 1)]);
//             }
//         }
    
//     }
//     else {
//         return index[0];
//     }
// }
// int[] array = {1, 3, 2, 6, 4, 5, 9, 7, 8};
// int[] index = {};
// array = QuickSort(array);
// foreach (int arr in array)
// {
//     Console.WriteLine(arr);
// }
// Console.WriteLine(Bin_search(array, 5, index));

// string Obhod(string[][] derevo, int level = 0, int i = 0)
// {
//     if (level >= derevo.GetLength(0)) {
//         return "";
//     }
//     if (i == 0){
//         Console.Write($"Узлы {level} уровня : {derevo[level][i]} ");
//         return Obhod(derevo, level, i++);
//     }
//     else if (i < derevo[level].Length){
//         Console.Write($"{derevo[level][i]} ");
//         return Obhod(derevo, level, i++);
//     }
//     else{
//         Console.WriteLine(".");
//         return Obhod(derevo, level++, 0);
//     }
// }
// Obhod(derevo);
