int[] numbers = {1, 2, 3, 4, 5};
int[] numbers1 = {6, 7, 8, 9, 10};
int[] numbers_all = new int[(numbers.Length + numbers1.Length)];

for (int i = 0; i < numbers.Length; i++)
{
    numbers_all[i] = numbers[i];
}

for (int i = 0; i < numbers1.Length; i++)
{
    numbers_all[i + numbers.Length] = numbers1[i];
}

foreach (int item in numbers_all)
{
    Console.WriteLine(item);
}
