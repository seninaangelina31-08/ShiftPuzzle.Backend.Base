int[] arr = { 10, -2, 3, 4, 20, 5 };


int min = arr[0];
int max = arr[0];

for (int i = 0; i < arr.Length; i++ ) //i = i + 1 получается i = 10 + 1 чото не понятно. 
{
    if (arr[i] < min) // min = 0 или 0 элементу в массиве, значит min изначально равен 10?
    {
         min = arr[i];
    }
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

Console.WriteLine("\nМинимальный элемент: " + min);
Console.WriteLine("Максимальный элемент: " + max);