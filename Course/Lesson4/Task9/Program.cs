int[] array = {213, 23, 2, 3, 1, 535, 5};
int s;
for (int y = 0; y < array.Length; y++)
{
    for (int i = y; i < array.Length; i++)
    {
        if (array[y] > array[i])
        {
            s = array[i];
            array[i] = array[y];
            array[y] = s;
        }
    }
    Console.WriteLine(array[y]);
}
