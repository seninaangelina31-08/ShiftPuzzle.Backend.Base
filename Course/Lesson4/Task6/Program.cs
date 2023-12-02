namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, -2, 3, 4, -5 };
        int search_element = -2;
        bool is_found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == search_element)
            {
                is_found = true;
                break;
            }
        }

        if (is_found)
        {
            Console.WriteLine($"Элементик {search_element} найден в массиве");
        }

        else
        {
            Console.WriteLine($"Элементик {search_element} не найден в массиве");
        }
    }
}
