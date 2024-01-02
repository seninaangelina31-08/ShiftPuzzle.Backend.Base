int[] numbers = [5, 4, 3, 2, 1];
int a;

for (int b = 0; b < numbers.Length; b++)
{
    for (int i = b; i < numbers.Length; i++)
    {
        if (numbers[b] > numbers[i])
        {
            a = numbers[i];
            numbers[i] = numbers[b];
            numbers[b] = a;
        }
    }
    Console.WriteLine(numbers[b]);
}