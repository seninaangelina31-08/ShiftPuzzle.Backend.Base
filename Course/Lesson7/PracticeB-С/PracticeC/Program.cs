namespace PracticeC;
//P.S Не смотрите это, это мы с Никитой думали, как бы еще можно решить задачу

// public class UZEL
// {
    // ЗДЕСЬ СОЗДАЕМ ЗНАЧЕНИЕ УЗЛА;
    // СОЗДАЛИ ЛЕВОГО РЕБЕНКА ОТ КЛАССА UZEL;
    // СОЗДАЛИ ПРАВОГО РЕБЕНКА ОТ КЛАССА UZEL;
// 
    // ЗДЕСЬ ПИШЕМ МЕТОД, ГДЕ ПРИСВАИВАЕМ ЗНАЧЕНИЕ УЗЛА УЗЛУ
// }
// public class DEREVO
// {
    // СОЗДАЛИ ОБЪЕКТ КЛАССА UZEL
    // МЕТОД ПОИСКА НАИМЕНЬШЕГО
    // {
        // ЕСЛИ ОБЪЕКТ ОТ УЗЛА.ЛЕВЫЙ РЕБЕНОК == NULL
        // {
            // return ОБЪЕКТ ОТ УЗЛА.ЗНАЧЕНИЕ
        // }
    // }   
// }

class Program
{
    public static int Minimum_ot_dereva(string[] tree)
    {
        return Find_min(tree, 0);
    }

    public static int Find_min(string[] tree, int index)
    {
        if (index >= tree.Length)
        {
            return int.MaxValue;
        }

        string cur = tree[index];
        if (cur == "Null")
        {
            return int.MaxValue;
        }
        int left_child_index = index * 2 + 1;

        int left_child_min = Find_min(tree, left_child_index);

        return Math.Min(Convert.ToInt32(cur), left_child_min);
    }
    static void Main(string[] args)
    {
        string[] tree = {"4", "2", "5", "Null", "3"};
        
        int min_el = Minimum_ot_dereva(tree);
        Console.Write(min_el);

    }
}
