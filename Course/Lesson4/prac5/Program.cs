// See https://aka.ms/new-console-template for more information
int[] mass = {1, 43, 12, 34, 545, -6};

int x = 0;
foreach (int n in mass)
{
    if (n<0){
        x += 1;
    }
}
Console.WriteLine(x);
