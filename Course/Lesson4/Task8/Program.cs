namespace Task8;

class Program
{
    static void Main(string[] args)
    {
        //Напишите программу для нахождения минимального и максимального элементов в массиве._
        int max =-10000;
        int min=10000;
        int[] numbers = {1, 3, 7, 8, -6, 4, -2, 12, 6};
        for(int i=0; i<9;i+=1)
        {
            if  (max<numbers[i]){
                 
                 max = numbers[i];
            }
       
        }
        for(int i=0; i<9;i+=1){
            if (min>numbers[i])
            {
                min=numbers[i];
            }
        }
        Console.WriteLine($"Наибольшее число: {max}");
        Console.WriteLine($"Наименьшее число: {min}");
    
    }
}
