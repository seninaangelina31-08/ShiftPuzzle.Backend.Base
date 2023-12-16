int[] arr1 = {1, 2, 3};
int [] arr2 = {4, 5, 6};

int[] result = new int [arr1.Length + arr2.Length];
Arr.Copy(arr1, result, arr1.Length)
Arr.Copy(arr2, 0, result, arr1.Length, arr2.Length);

foreach (int i in result)
{
    Console.Write(i + " ");
}


