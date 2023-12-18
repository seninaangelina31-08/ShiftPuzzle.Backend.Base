namespace PracticeA;
class Program
{
    static void Main(string[] args)
    {
    }
    //task1
    static int Factorial(int a)
    {
        if (a <= 1)
        {
            return 1;
        }
        else
        {
            return a * Factorial(a - 1);
        }
    }
    //task2
    static int FibonachiNums(int num)
    {
        if (num <= 2)
        {
            return 1;
        }
        else
        {
            return FibonachiNums(num - 1) + FibonachiNums(num - 2);
        }
    }
    //task3
    static string Revers(string a)
    {
        if (a.Length <= 1)
        {
            return a;
        }
        else
        {
            return a[a.Length - 1] + Revers(a.Substring(0, a.Length - 1));
        }
    }
    //task4
    static int Sum(int[] a)
    {
        if (a.Length == 1)
        {
            return a[0];
        }
        else
        {
            return Sum(a[0..(a.Length - 1)]) + a[a.Length - 1];
        }
    }
    //task5
    static int EvclidAlhoritm(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            return a + b;
        }
        else
        {
            if (a > b)
            {
                return EvclidAlhoritm(a % b, b);
            }
            else
            {
                return EvclidAlhoritm(a, b % a);
            }
        }
    }
    //task6
    static bool isPolindrome(string a)
    {
        if (a == Revers(a))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //task8
    static int[][] SortThrough(int[][] a)
    {
        if (a.Length <= 0)
        {
            return a;
        }
        else
        {
            foreach (int b in a[0])
            {
                Console.Write(b);
            }
            Console.WriteLine();
            return (SortThrough(a[1..(a.Length)]));
        }
    }
    //task9
    static void CopyTree(TreeNode at, BinaryTree to)
    {
        if (at != null)
        {
            to.Insert(at.Value);
            CopyTree(at.Left, to);
            Console.Write(at.Value + " ");
            CopyTree(at.Right, to);
        }
    }
    //task7
    static void SolveHanoi(int n, char fromPeg, char toPeg, char auxPeg)
    {
        if (n == 1)
        {
            Console.WriteLine($"Переместить диск 1 с {fromPeg} на {toPeg}");
            return;
        }

        SolveHanoi(n - 1, fromPeg, auxPeg, toPeg);
        Console.WriteLine($"Переместить диск {n} с {fromPeg} на {toPeg}");
        SolveHanoi(n - 1, auxPeg, toPeg, fromPeg);
    }


}

class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    public TreeNode Root { get; set; }

    public BinaryTree()
    {
        Root = null;
    }

    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    private TreeNode InsertRec(TreeNode root, int value)
    {
        if (root == null)
        {
            root = new TreeNode(value);
            return root;
        }

        if (value < root.Value)
        {
            root.Left = InsertRec(root.Left, value);
        }
        else if (value > root.Value)
        {
            root.Right = InsertRec(root.Right, value);
        }

        return root;
    }

    public void Delete(int value)
    {
        Root = DeleteRec(Root, value);
    }

    private TreeNode DeleteRec(TreeNode root, int value)
    {
        if (root == null)
        {
            return root;
        }

        if (value < root.Value)
        {
            root.Left = DeleteRec(root.Left, value);
        }
        else if (value > root.Value)
        {
            root.Right = DeleteRec(root.Right, value);
        }
        else
        {
            if (root.Left == null)
            {
                return root.Right;
            }
            else if (root.Right == null)
            {
                return root.Left;
            }

            root.Value = GetMinValue(root.Right);

            root.Right = DeleteRec(root.Right, root.Value);
        }

        return root;
    }

    private int GetMinValue(TreeNode root)
    {
        int minValue = root.Value;
        while (root.Left != null)
        {
            minValue = root.Left.Value;
            root = root.Left;
        }
        return minValue;
    }

    public void TraverseInOrder(TreeNode root)
    {
        if (root != null)
        {
            TraverseInOrder(root.Left);
            Console.Write(root.Value + " ");
            TraverseInOrder(root.Right);
        }
    }
}