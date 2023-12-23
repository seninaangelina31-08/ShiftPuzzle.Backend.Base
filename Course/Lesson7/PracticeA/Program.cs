namespace PracticeA;

class Program
{
    static void Main(string[] args)
    {
        string t1 = rev("mmeow");
    
        Console.WriteLine(t1);
    }
    //**Факториал числа**
    //- Написать рекурсивную функцию для вычисления факториала числа.
    public static int recurs(int c)
    {
        if (c<=1)
        {
            return 1;
        }
        else
        {
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

