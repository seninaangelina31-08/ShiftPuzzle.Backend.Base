// See https://aka.ms/new-console-template for more information
int[] mass = {1, 43, 12, 34, 545};

int max = mass[0];

foreach (int n in mass)
{
    if (n>max){
        max = n;
    }
}

Console.WriteLine(max);
