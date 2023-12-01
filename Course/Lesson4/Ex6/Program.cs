namespace Ex6;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = {5, 15, 23, -7, 16, -74, 50, 2};
        Console.WriteLine("Введите число для поиска в массиве:");
        int a = Convert.ToInt16(Console.ReadLine());
        int i = 0;
        bool found = false;
        for(;i < arr.Length; i++)
        {
            if (arr[i] == a)
            {
                found = true;
                break;
            }
        }
        if (found)
            Console.WriteLine($"Искомый элемент находится в массиве под индексом: {i}");
        else
            Console.WriteLine("В массиве нет введёного элемента");
    }
}
