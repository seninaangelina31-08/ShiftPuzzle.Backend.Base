int[] numbers = {1, 2, 3, 4, 5};
int sum = CalculateNumberSum(numbers, 0);
Console.WriteLine($"Сумма элементов массива: {sum}");

static CalculateNumberSum(int[] num, int index)
{
    if (index == num.Length)
    {
        return 0;
    }
    else
    {
        return num[index] + CalculateNumberSum(num, index +1);
    }
}