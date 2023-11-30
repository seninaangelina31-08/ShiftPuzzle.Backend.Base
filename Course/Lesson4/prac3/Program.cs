// See https://aka.ms/new-console-template for more information
int[] mass = {1, 43, 12, 34, 545};

int l = mass.Length;

for (int i = 0; i < l-1; ++i)
{
    int x = mass[i];
    mass[i] = mass[l-1-i];
    mass[l-1-i] = x;
    Console.WriteLine(mass[i]);
}


