int[] arr = { 5, -8, 3, -2, 9 };

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] < 0)
    {
        arr[i] = 0;
    }
}

Console.WriteLine("\nМассив с заменой отрицательных элементов нулями: ");
foreach (int num in arr)
{
    Console.Write(num + " ");
}