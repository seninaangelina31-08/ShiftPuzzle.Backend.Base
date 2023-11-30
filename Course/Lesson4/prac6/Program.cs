// See https://aka.ms/new-console-template for more information
int[] mass = {1, 43, 12, 34, 545};

int n = mass.Length;

Console.Write("Ввести элемент поиска: ");
     int b = Convert.ToInt32(Console.ReadLine());
    
    int k = -1;
     for (int i = 0; i < n; i++)
     {
        if (mass[i] == b){
             k = i;}
     }
     
Console.WriteLine(k);
