int[] array = {1, 2, 3, 4, 5};
int i = 1;
int s;
do
{
    if (array[i] > array[0])
    {
        s = array[0];
        array[0] = array[i];
        array[i] = s;
    }
    i++;
} while (i < array.Length);
Console.WriteLine(array[0]);