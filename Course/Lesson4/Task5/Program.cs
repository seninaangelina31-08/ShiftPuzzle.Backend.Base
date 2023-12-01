int[] array = {-5, -4, -3, -2, 1, 0, 23, -123, 3};
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] < 0)
    {
        count ++;
    }
}
Console.WriteLine(count);