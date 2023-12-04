int[] array = {1, 2, 3, 4, 5};
int[] array1 = {6, 7, 8, 9, 10};
int[] array_mirage = new int[(array.Length + array1.Length)];
for (int i = 0; i < array.Length; i++)
{
    array_mirage[i] = array[i];
}
for (int i = 0; i < array1.Length; i++)
{
    array_mirage[i + array.Length] = array1[i];
}
foreach (int item in array_mirage)
{
    Console.WriteLine(item);
}