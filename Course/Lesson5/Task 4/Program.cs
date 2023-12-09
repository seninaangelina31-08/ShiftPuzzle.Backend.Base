namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
int[] arr = {1, 2, 3, 4, 5,};
int k = 2;
int time_per = 0;
int[] tempArray = new int[arr.Length];


        foreach (var i in arr)
            {
                Console.Write(i + " " );
                
            }

        for (int i = 1; i < arr.Length - 1; i++)
        {
                time_per += k;
                time_per %= arr.Length;
                tempArray[i] = arr[time_per];
        }
    Console.WriteLine("==> " + string.Join(" ", tempArray));

            //Второй вариант решения

            // for (int i = 1; i < array.Length; i++)
            // {
            //     tempArray[(i + k) % array.Length] = array[i];
            //     Console.WriteLine(i + " ");
            // }

            // for (int i = 0; i < array.Length; i++)
            // {
            //     array[i] = tempArray[i];
            // }
            // Console.Write("");
            // foreach (var i in array)
            // {
            //     Console.Write(i + " ");
            // }










    }
}
