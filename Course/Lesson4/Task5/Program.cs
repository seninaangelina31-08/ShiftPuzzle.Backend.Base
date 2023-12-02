namespace Task5;

class Program
{
    static void Main(string[] args)
    {
        //Напишите программу для подсчета количества отрицательных чисел в массиве._
    
        int i=0;
        int j=0;
        int[] numbers = {1,-3,7,8,-6};
        while(j<5){
            if (numbers[j]<0)
            {
                i++;
            }
            j+=1;
            
        }
        Console.WriteLine(i);
    }
}
