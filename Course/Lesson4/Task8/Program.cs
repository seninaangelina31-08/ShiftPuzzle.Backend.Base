int[] array = {3, 2, 3, 4, 5, 123213, 32, 23231, 1};
int i = 1;
int s;
do
{
    if (array[i] < array[0])
    {
        s = array[0];
        array[0] = array[i];
        array[i] = s;
    }
    i++;
} while (i < array.Length);
Console.Write("Min:");
Console.WriteLine(array[0]);


i = array.Length - 1;
do
{
    if (array[i] > array[(array.Length - 1)])
    {
        s = array[(array.Length - 1)];
        array[(array.Length - 1)] = array[i];
        array[i] = s;
    }
    i--;
} while (i > 1);
Console.Write("Max:");
Console.WriteLine(array[(array.Length - 1)]);