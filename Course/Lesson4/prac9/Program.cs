// See https://aka.ms/new-console-template for more information
int[] mass = {1, 43, 12, 34, 545};

for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        int z = mass[j];
                        mass[j]=mass[j+1];
                        mass[j + 1] = z;
                    }
                }
            }

Console.WriteLine(mass[1]);