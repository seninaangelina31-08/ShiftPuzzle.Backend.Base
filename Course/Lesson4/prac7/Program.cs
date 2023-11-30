// See https://aka.ms/new-console-template for more information
int[] mass = {1, 43, 12, 34, 545, -6};

int x = mass.Length;
for (int i = 0; i<x; ++i)
{
    if (i%2==1){
        Console.WriteLine(mass[i]);
    }
}

