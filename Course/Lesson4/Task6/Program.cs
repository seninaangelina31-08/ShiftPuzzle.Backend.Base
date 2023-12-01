int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int i = Convert.ToInt32(Console.ReadLine());
int x = 0;
while (true)
{
    if (i == array[x])
    {
        Console.WriteLine(x);
        break;
    }
    x++;
}