namespace Task3;

class Program
{
    static void Main(string[] args)
    {
       // _Напишите программу, которая переворачивает массив (последний элемент становится первым, и так далее)._
       int j=4;
       
       int t=0;
       int[] numbers = {1,3,7,8,6};
       for (int i=0;  i < j; i++)
       {
        t = numbers[i];
        numbers[i] = numbers[j];
        numbers[j] = t;
        j--;
        }
        var str = string.Join(" ", numbers);
        Console.WriteLine(str);
    
    }
}
