namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        //_Напишите программу для вычисления суммы всех элементов в массиве целых чисел._
        int i=0;
        int d=0;
        int[] numbers = {1,3,7,8,6};
        while(i<5){
            d+=numbers[i];
            i++;
        }
      
        Console.WriteLine(d);
    }
}
