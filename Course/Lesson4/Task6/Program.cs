namespace Task6;
class Program
//6. **Линейный поиск**
//   _Реализуйте линейный поиск заданного элемента в массиве._

{
    static void Main(string[] args)
    //Ищем 15
    {
        int[] array_1 = {0, 1, 22, 33, 23, 44, 15};
        bool array_1_search_15 = false;
        foreach(int number in array_1)
        {
            if (15 == number)
            {
                array_1_search_15 = true;
            }
        }
        Console.WriteLine(array_1_search_15);
    }
}
