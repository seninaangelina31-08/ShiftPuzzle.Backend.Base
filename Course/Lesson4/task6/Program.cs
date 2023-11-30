namespace task6;

class Program
{
    static void Main()
    {
        int[] array = {1, 2, 3, 4};
        Console.WriteLine("Напишите искомый элемент");
        int number= Convert.ToInt32(Console.ReadLine());
        foreach(int i in array)
        {
            if (i == number)
            {
                Console.WriteLine("Искомый элемент " + number + " найден");
            }
        }
    }
}
