<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
namespace PracticeA;
=======
﻿namespace PracticeA;
>>>>>>> main
=======
﻿namespace PracticeA;

>>>>>>> 2a6ab33e (feat: added answer to task 7)
class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
    }
    //task1
    static int Factorial(int a)
    {
        if (a <= 1)
=======
        string t1 = rev("mmeow");
    
        Console.WriteLine(t1);
    }
    //**Факториал числа**
    //- Написать рекурсивную функцию для вычисления факториала числа.
    public static int recurs(int c)
    {
        if (c<=1)
>>>>>>> 2a6ab33e (feat: added answer to task 7)
        {
            return 1;
        }
        else
        {
<<<<<<< HEAD
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
=======
            return c*recurs(c-1);
        }

    }



    // **Числа Фибоначчи**
    // Рекурсивно находить n-ое число Фибоначчи.
    public static int fib(int n)
    {
        if (n <= 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else{
            return fib(n - 1) + fib(n - 2);
        }
    }

    // **Обращение строки**
    //Создать рекурсивную функцию для обращения строки.
    public static string rev(string str)
    {
        if (str.Length <= 1)
        {
            return str;
        }
        return rev(str.Substring(1)) + str[0];
    }

    //**Сумма элементов массива**
    //Написать рекурсивную функцию для нахождения суммы элементов массива.
    public static int summas(int[] numbers, int i = 0)
    {
        if (i >= numbers.Length){
            return 0;
        }
        return numbers[i] + summas(numbers, i + 1);
    }
    

    //**Наибольший общий делитель (НОД)**
    //Реализовать алгоритм Евклида для нахождения НОД двух чисел с использованием рекурсии.
    public static int nod(int a, int b)
    {
        if (b == 0){
            return a;
        }
        return nod(b, a % b);

    }

    //**Проверка палиндрома**
    //Создать рекурсивную функцию, которая проверяет, является ли строка палиндромом.
    public static bool pal(string str)
    {
        if (str.Length <= 1)
        {
            return true;
        }
        if (str[0] != str[str.Length - 1])
        {
            return false;
        }
        return pal(str.Substring(1, str.Length - 2));

    }

    // **Ханойские башни**
    // Решить задачу о Ханойских башнях с использованием рекурсии.
    public static void HanoiTower(int n, char a, char b, char c)
    {
    if (n == 1)
    {
        Console.WriteLine($"Переместить дпервый диск с {a} на {c}");
        return;
    }

    HanoiTower(n - 1, a, c, b);
    Console.WriteLine($"Переместить диск  {n} с {a} на {c}");
    HanoiTower(n - 1, b, a, c);
    }

    // **Перебор подмножеств множества**
    // Написать функцию, которая рекурсивно перебирает все подмножества данного множества.
    public static void GenerateSubsets(int[] set, int i, int[] podmn)
    {
        if (i == set.Length)
        {
            // Обработка полученного подмножества
            Console.Write("Subset: ");
            foreach (int e in podmn)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
            return;
        }

        // Вызов функции для следующего элемента, включая текущий элемент в подмножество
        podmn[i] = set[i];
        GenerateSubsets(set, i + 1, podmn);

        // Вызов функции для следующего элемента, исключая текущий элемент из подмножества
        podmn[i] = 0;
        GenerateSubsets(set, i + 1, podmn);
    }

    // **Глубокое копирование объекта**
    // Реализовать рекурсивное глубокое копирование сложного объекта (например, дерева).
    public void insert(int x) 
    {
        root = ins(root, x);
    }
    
    private static Node ins(Node node, int x) {
        if (node == null) 
        {
            return new Node(x);
        }
        if (x < node.key) 
        {
            node.left = ins(node.left, x);
        } 
        else if (x > node.key) 
        {
            node.right = ins(node.right, x);
        }
        return node;
    }
    // **Генерация всех возможных перестановок**
    // Написать функцию для генерации всех возможных перестановок заданного списка или строки.
    public static string generate(string str)
{
    if (str.Length <= 1)
    {
        return str;
    }

    string ab = string.Empty;

    foreach (char c in str)
    {
        string cd = string.Empty;

        foreach (char i in str)
        {
            if (i != c)
            {
                cd += i;
            }
        }

        string remab = generate(cd);

        foreach (char a in remab)
        {
            ab += c + a.ToString() + " ";
        }
    }

    return ab.TrimEnd(',');
}

}

>>>>>>> 2a6ab33e (feat: added answer to task 7)
=======
﻿
>>>>>>> 3dfd26bb (feat: lesson 5-lesson 12)
