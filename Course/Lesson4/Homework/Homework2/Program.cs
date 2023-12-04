int[] array = {1, 2, 3, 4, 5};
int[] array1 = new int[array.Length];
foreach (int arr in array)
{
    Console.Write(arr);
}
Console.WriteLine();
int i1 = 0;
string s = Console.ReadLine() ?? "1";
int s1 = Convert.ToInt32(s);
for (int i = 0; i < array.Length; i++)
{
    i1 = i + s1;
    while ((i1 > array.Length) || (i1 == array.Length))
    {
        i1 -= array.Length;
    }
    array1[i1] = array[i];
}
foreach (int arr in array1)
{
    Console.Write(arr);
}
Console.WriteLine();