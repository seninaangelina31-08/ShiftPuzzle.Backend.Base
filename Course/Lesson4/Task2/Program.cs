namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        //_Создайте программу для нахождения максимального значения в массиве целых чисел._
        int max =0;

        int[] numbers = {1,3,7,8,6};
        for(int i=0; i<5;i+=1)
        {
            if  (max<numbers[i]){
                 max = numbers[i];
            }
       
        }
         Console.WriteLine(max);
       
    }
}
