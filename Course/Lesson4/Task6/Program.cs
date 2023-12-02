namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        //Реализуйте линейный поиск заданного элемента в массиве._
        int b=8;
        int j=0;
        int[] numbers = {1,3,7,8,6};
        while(j<5){
            if (numbers[j]==b)
            {
                Console.WriteLine(j);

            }
            j+=1;

        }
    }
}
