namespace Task4;

class Program
{
    static void Main(string[] args)
    {
        int j=0;
        //_Создайте программу, которая выводит все четные числа из заданного массива._
        int[] numbers = {1,3,7,8,6};
        while(j<5){
            if (numbers[j]%2==0)
            {
                Console.WriteLine(numbers[j]);

            }
            j+=1;

        }

    }
}
