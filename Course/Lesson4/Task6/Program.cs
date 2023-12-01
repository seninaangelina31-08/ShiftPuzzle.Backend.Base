namespace Task6;
class Program
{
    static void Main(string[] args)
    {


        int[] array = {1, 4, 19, 23, 9123, 10244, -129, 200};
        int req_el = 23;

        for (int i = 0; i < array.Length; i++)
        {
            if (req_el == array[i])
            {
                Console.WriteLine($"Позиция требуемого элемента: {i}");
                break;
            }
        }


    }
}
