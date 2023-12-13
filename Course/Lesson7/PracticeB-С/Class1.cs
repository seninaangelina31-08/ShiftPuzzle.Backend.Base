namespace PracticeB_C;

public class Class1
{
    public static bool RecPoisk(Code[,] labirint, int row, int col, Dir dir)
        {
            if ((labirint[row, col] & Code.Finish) != 0)
            {
                Console.Write($"[{row},{col}]");
                return true;
            }
            bool reached = false;
    
            if ((labirint[row, col] & Code.Left) != 0 && dir != Dir.Right)
                reached = RecPoisk(labirint, row, col - 1, Dir.Left);

            if (!reached && (labirint[row, col] & Code.Right) != 0 && dir != Dir.Left)
                reached = RecPoisk(labirint, row, col + 1, Dir.Right);

            if (!reached && (labirint[row, col] & Code.Up) != 0 && dir != Dir.Down)
                reached = RecPoisk(labirint, row - 1, col, Dir.Up);

            if (!reached && (labirint[row, col] & Code.Down) != 0 && dir != Dir.Up)
                reached = RecPoisk(labirint, row + 1, col, Dir.Down);
            if(reached)
                Console.Write($"<-[{row},{col}]");

            return reached;
        }

        static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;
        
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;
        
        return i + 1;
    }

    public static int findMinRec(Node node)
    {
        if (node == null)
        {
            Console.WriteLine("Дерево пустое");
            return int.MaxValue;
        }
        else if (node.left == null)
            return node.data;

        return findMinRec(node.left);
    }
    public static int findMin()
    {
        return findMinRec(root);
    }

    static int BinarySearch(int[] arr, int low, int high, int target)
    {
        if (high >= low)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return mid;

            if (arr[mid] > target)
                return BinarySearch(arr, low, mid - 1, target);

            return BinarySearch(arr, mid + 1, high, target);
        }
        return -1;
    }
}
