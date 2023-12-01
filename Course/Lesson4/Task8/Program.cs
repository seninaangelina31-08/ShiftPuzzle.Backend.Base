namespace Task8;
class Program
{
    static void Main(string[] args)
    {
        int[] array = {-100, 10, 1245, 111111, 999, -998123, 24};
        int minel = array[0];
        int maxel = array[0];

        foreach (int el in array)
        {
            if (minel > el)
            {
                minel = el;
            }
            if (maxel < el)
            {
                maxel = el;
            }
        }
        Console.WriteLine($"Наибольший элемент: {maxel}");
        Console.WriteLine($"Наименьший элемент: {minel}");
        
    }
}
