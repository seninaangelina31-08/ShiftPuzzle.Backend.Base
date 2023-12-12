// task1
void MaxSumSubArray(int[] arr, int N)
{
    int[] maxArray = new int[N];
    int maxSum = 0;

    for (int i = 0; i < arr.Length - N + 1; i++)
    {
        int tempSum = 0;
        int[] subArray = new int[N];
        for (int j = 0; j < N; j++)
        {
            subArray[j] = arr[i + j];
            tempSum += arr[i + j];
        }

        if (tempSum > maxSum)
        {
            maxSum = tempSum;
            maxArray = subArray;
        }
    }
    Console.WriteLine($"Исходный массив [{string.Join(", ", arr)}] \nПодмассив с максимальной суммой элементов: [{string.Join(", ", maxArray)}]");
}
int[] array = {42, 5, 51, 25, 58, 11, 13, 4, 23, 96, 7, 56};
MaxSumSubArray(array, 3);

// task2
// -_-

