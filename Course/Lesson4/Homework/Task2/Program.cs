namespace Task2;
class Program
{
    int[]arr = {1, 2, 3, 4, 5};
    int n = arr.Length;
    int k = Int32.Parse (Console.ReadLine());
    for (int i = 0; i < n; i++) {
        Console.Write(arr[i]);
        Console.Write(' ');
    }
    Console.Write('\n');
    int[] temp = new int[n];

    for (int i = 0; i < n; i++)
    {
        temp[(i + k) % n] = arr[i];
    }

    for (int i = 0; i < n; i++)
    {
        arr[i] = temp[i];
    }
    for (int i = 0; i < n; i++) {
        Console.Write(arr[i]);
        Console.Write(' ');
    }
}

