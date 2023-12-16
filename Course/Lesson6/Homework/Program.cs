namespace Homework;

class Program
{
    static void Main(string[] args)
    {
    int[] mass = {6, 1, 2, 3, 4, 6, 6, 5, 6, };
    int[] new_mass = new int[mass.Length];
    int c = 1;
    int max = 0;
    for(int i = 0; i < mass.Length; i++)
    {

    for(int j = 0; i < i; j++) 
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
}
