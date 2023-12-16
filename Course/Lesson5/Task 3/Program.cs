namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
    int[] mass = {1, 1, 2, 3, 4, 6, 1, 5, 6, };
    int[] new_mass = new int[mass.Length];
    int c = 1;
    int max= 0;
    for(int i = 0; i< mass.Length; i++)
    {

    for(int j = 0; i< i; j++) 
    if (mass[i] == mass[j]) c++;
    new_mass[i] = c;
    }

for(int i = 1; i < mass.Length; i++)
{
    if (mass[max] < new_mass[i]) 
    {
        max = i;
    }
}
Console.WriteLine(mass[max]);

    }

public static void dumpMatrix<T>(T[,] a)
{
    int m = a.GetLength(0);
    int n = a.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}

}
