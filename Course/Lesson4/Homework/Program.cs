// See https://aka.ms/new-console-template for more information
// Practice 1
int[] mass1 = [2, 6, 12, 45, 5, 2, 4, 5];
int[] mass2 = [2, 6, 12, 45, 5, 2, 4, 5];

int[] mass3 = new int[mass1.Length + mass2.Length];

for (int i = 0; i<mass1.Length; i++){
    mass3[i] = mass1[i];
}

for (int j = 0; j < mass2.Length; j++){
    mass3[mass1.Length + j] = mass2[j];
}
Console.WriteLine("\nОбъединённый массив: " + string.Join(", ", mass3));

