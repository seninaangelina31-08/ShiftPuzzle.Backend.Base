namespace Task7;
class Program
{
    static void Main(string[] args)
    {   
        string[] array = {"Zero_str", "First_str", "Second_str", "Third_str"};
        
        Console.WriteLine("Элементы на нечетных позициях: ");

        for (int i = 0; i < array.Length; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
