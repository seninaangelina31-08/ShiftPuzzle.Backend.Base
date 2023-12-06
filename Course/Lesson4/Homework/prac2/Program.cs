// See https://aka.ms/new-console-template for more information

int[] mass = [1, 45, 34, 234, 57, 23];
int K = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine(string.Join(" ", mass));
            
            
int[] mass2 = new int[mass.Length];

for (int i = 0; i < mass.Length; i++){   
    if (i + K>= mass.Length){
        mass2[(i + K) - mass.Length] = mass[i];
        } 
    else{
        mass2[i + K] = mass[i];
        }
    }

Console.WriteLine("Измененный массив: " + string.Join(", ", mass2));

