// Task 1
int[] arrayOne = {1, 2, 3, 4, 5, 11, 12, 13, 14};
int[] arrayTwo = {3, 6, 7, 4, 8, 2, 9, 5, 10, 1};
int[] mergedArray = new int [(arrayOne.Length + arrayTwo.Length)];

for (int i = 0; i < arrayOne.Length; i++)
{
    mergedArray[i] = arrayOne[i];
}

for (int i = 0; i < arrayTwo.Length; i++)
{
    mergedArray[i + arrayOne.Length] = arrayTwo[i];
}

Console.WriteLine(String.Join(", ", mergedArray));

// Task 2
int[] array = {1, 2, 3, 4, 5};
int[] resArray = new int[array.Length];
Console.WriteLine("Исходный массив: [" + string.Join(", ", array) + "]");
Console.Write("Введите число позиций ротации: ");
int K = int.Parse(Console.ReadLine()!);

for (int i = 0; i < array.Length; i++)
{
    resArray[(i + K) % array.Length] = array[i];
}

Console.WriteLine("Массив с ротацией вправо на К позиций: [" + string.Join(", ", resArray) + "]");

