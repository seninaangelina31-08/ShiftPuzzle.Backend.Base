int[] arr= {1, 2, 3, 4, 5};
int rotate = 2;

int[] result = new int[arr.Length];

for ( i = 0; i < arr.Length; i++)
{
    int nowoe = (i + rotate)  % arr.Length;
    result[nowoe] = arr[i];
}

foreach (int i in result)
{
    Console.Write(i + " ");
}

