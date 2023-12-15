namespace PracticeB_С;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("11 задание:");
        int[,] maze = 
        {
            {1, 1, 1, 0, 1},
            {0, 0, 1, 1, 1},
            {0, 0, 0, 0, 1},
            {1, 1, 1, 0, 1},
            {0, 0, 1, 1, 1}
        };

        if (FindPath(maze, 0, 0))
            Console.WriteLine("Путь найден!");
        else
            Console.WriteLine("Путь не найден!");


        Console.WriteLine("12 задание:");


        Console.WriteLine("14 задание:");
        int[] array = { 1, 4, 7, 9, 12, 15, 20 };
        int target = 9;
        int n = array.Length;

        int result = Binary(array, target, 0, n - 1);

        if (result != -1)
        {
            Console.WriteLine("Элемент найден в позиции " + result);
        }
        else
        {
            Console.WriteLine("Элемент не найден");
        }
    }


// 11 задание
    public static bool FindPath(int[,] maze, int x, int y)
    {
        int n = maze.GetLength(0);
        int m = maze.GetLength(1);

        // Проверка, достигли ли мы выхода из лабиринта
        if (x == n - 1 && y == m - 1)
            return true;

        // Проверка, находится ли текущая позиция в пределах лабиринта и является ли она проходимой
        if (x >= 0 && x < n && y >= 0 && y < m && maze[x, y] == 1)
        {
            // Помечаем текущую позицию как посещенную
            maze[x, y] = 0;

            // Рекурсивно ищем путь вправо, вниз, влево и вверх от текущей позиции
            if (FindPath(maze, x + 1, y))
                return true;

            if (FindPath(maze, x, y + 1))
                return true;

            if (FindPath(maze, x - 1, y))
                return true;

            if (FindPath(maze, x, y - 1))
                return true;

            // Если ни один из путей не приводит к выходу из лабиринта, то отмечаем текущую позицию как непроходимую
            maze[x, y] = 1;
        }

        return false;
    }


// 12 задание
    static void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            // int pivotIndex = Partition(array, low, high);
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int k = low;
            int t = array[i];
            array[i] = array[k];
            array[k] = t;

            i = i + 1;

            QuickSort(array, low, i - 1);
            QuickSort(array, i + 1, high);
        }
    }


// 14 задание
    public static int Binary(int[] array, int target, int low, int high)
    {
        if(low <= high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] == target)
            {
                return mid;
            }

            if (array[mid] < target)
            {
                return Binary(array, target, mid + 1, high);
            }

            return Binary(array, target, low, mid - 1);
        }

        return -1;
    }
}
