int[] array = {1, 2, 3, 4, 5};
int i = 0;
int i1 = array.Length  - 1;
int s;
do
{
    s = array[i];
    array[i] = array[i1];
    array[i1] = s;
    i++;
    i1--;
} while (i < (array.Length / 2));
for (i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}