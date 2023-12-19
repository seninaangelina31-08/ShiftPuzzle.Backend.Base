namespace PracticeB_С;
class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD

    }
// Practice_B
    public static int[] MaxSubarray(int[] array)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < array.Length; i++)
        {
            currentSum += array[i];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                endIndex = i;
=======
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int[] maxSubarray = FindMaxSubarray(arr);

        Console.Write("Max subarray with maximum sum: ");
        foreach (int num in maxSubarray)
        {
            Console.Write(num + " ");
        }
    }

    public static int[] FindMaxSubarray(int[] arr)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;
        int start = 0;
        int end = 0;
        int s = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            currentSum += arr[i];

            if (maxSum < currentSum)
            {
                maxSum = currentSum;
                start = s;
                end = i;
>>>>>>> main
            }

            if (currentSum < 0)
            {
                currentSum = 0;
<<<<<<< HEAD
                startIndex = i + 1;
            }
        }
        int[] maxSubarray = new int[endIndex - startIndex + 1];
        Array.Copy(array, startIndex, maxSubarray, 0, maxSubarray.Length);

        return maxSubarray;
    }


// Practice_С 
    public static List<int[]> Permutations(int[] array)
    {
        List<int[]> permutations = new List<int[]>(); // Список для хранения перестановок
        GeneratePermutations(array, 0, permutations);
        return permutations;
    }

    private static void GeneratePermutations(int[] array, int currentIndex, List<int[]> permutations)
    {
        if (currentIndex == array.Length - 1)
        {
            int[] currentPermutation = new int[array.Length];
            Array.Copy(array, currentPermutation, array.Length);
            permutations.Add(currentPermutation);
        }
        else
        {
            for (int i = currentIndex; i < array.Length; i++)
            {
                SwapElements(array, currentIndex, i);
                GeneratePermutations(array, currentIndex + 1, permutations);
                SwapElements(array, currentIndex, i);
            }
        }
    }

    private static void SwapElements(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
=======
                s = i + 1;
            }
        }

        int[] result = new int[end - start + 1];
        Array.Copy(arr, start, result, 0, end - start + 1);
        return result;
    }
    
>>>>>>> main
}
