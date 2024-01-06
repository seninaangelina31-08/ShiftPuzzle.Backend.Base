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
void Perestanovka(string[] array)
{
    int[] count = new int[array.Length];
    string str = "";
    void Recursiv_10(string[] array, int[] count, string str, int i = 0, bool test = true)
    {
        if (count[0] >= array.Length)
        {
            Console.WriteLine();
        }
        else
        {
            if (i >= count.Length)
            {
                count[i - 1]++;
                i = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    for (int k = 0; k < str.Length; k++)
                    {
                        if (str[j] == str[k] && j != k) test = false;
                    }
                }
                if (test) 
                {
                    Console.WriteLine(str);
                }
                str = "";
            }
            if (i != (count.Length - 1) && count[i + 1] >= count.Length)
            {
                count[i + 1] = 0;
                count[i]++;
            }
            if (count[i] >= count.Length && i != 0)
            {
                count[i] = 0;
                count[i - 1]++;
            }
            if (count[0] >= count.Length)
            {
                return;
            }
            str += array[count[i]];
            Recursiv_10(array, count, str, i + 1);
        }
    }
    Recursiv_10(array, count, str);
}
string[] array_10 = {"0", "1", "2", "3"};
Perestanovka(array_10);
