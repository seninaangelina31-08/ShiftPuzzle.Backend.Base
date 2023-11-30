// See https://aka.ms/new-console-template for more information
int[] mass = {1, -34, 43, 12, 34, 545};


for (int i=0; i<mass.Length; i++)
{
    if (mass[i]<0){
        mass[i] = 0;
    }
}

Console.WriteLine(mass[1]);
