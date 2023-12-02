namespace Task10;

class Program
{
    static void Main(string[] args)
    {
        //Напишите программу, которая заменяет все отрицательные элементы в массиве нулями._
        
        int j=0;
        int[] numbers = {-1,3,-7,8,6};
        while(j<5){
            if (numbers[j]<0)
            {
                numbers[j]=0;

            }
            j+=1;
            
        }
        var str = string.Join(" ", numbers);
        Console.WriteLine(str);
 
    }
}
