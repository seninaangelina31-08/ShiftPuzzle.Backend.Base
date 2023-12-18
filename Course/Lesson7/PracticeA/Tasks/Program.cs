using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1-я задача ---");
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(2));
            Console.WriteLine(Factorial(3));

            Console.WriteLine("--- 2-я задача ---");
            Console.WriteLine(Fib(2));
            Console.WriteLine(Fib(3));
            Console.WriteLine(Fib(4));

            Console.WriteLine("--- 3-я задача ---");
            Console.WriteLine(Reverse("Строка"));
            Console.WriteLine(Reverse("I LOVE C#"));
            Console.WriteLine(Reverse("It's task №3"));

            Console.WriteLine("--- 4-я задача ---");
            double[] a = {1, 2, 3, 4, 5};
            double[] b = {1, 1, 1, 1, 1, 1, 1, 1, 1, 1};
            double[] c = {};
            Console.WriteLine(Sum(a));
            Console.WriteLine(Sum(b));
            Console.WriteLine(Sum(c));

            Console.WriteLine("--- 5-я задача ---");
            Console.WriteLine(NOD(5, 2));
            Console.WriteLine(NOD(6, 3));
            Console.WriteLine(NOD(20, 15));

            Console.WriteLine("--- 6-я задача ---");
            Console.WriteLine(Palindrome("12321"));
            Console.WriteLine(Palindrome("1234"));
            Console.WriteLine(Palindrome("exe"));

            Console.WriteLine("--- 7-я задача ---");
            HanoiTowers(5, 'A', 'B', 'C');

            Console.WriteLine("--- 8-я задача ---");
            int[] set = {1, 2, 3, 4, 5};
            IterateSubsets(set);

            Console.WriteLine("--- 10-я задача ---");
            int[] collection = {1, 2, 3};
            GetPermutations(collection);
        }

        // 1-я задача
        static double Factorial(double number) {
            if (number <= 0) {
                return 1;
            }
            return number * Factorial(number - 1);
        }

        // 2-я задача
        static double Fib(double number) {
            if (number <= 1) {
                return number;
            }
            return Fib(number - 1) + Fib(number - 2);
        }

        // 3-я задача
        static string Reverse(string str) {
            // Делаем пока строка не кончится
            if (str.Length <= 1)
            {
                return str;
            }
            // Использкем срез, чтобы проигнорить первый элемент и лепим в конец 
            // тот самый первый элемент, при этом в нашу функцию попадает строка 
            // на один символ меньше
            return Reverse(str.Substring(1)) + str[0];
        }

        // 4-я задача
        static double Sum(double[] array) {
            // Делаем пока длина массива не станет равняться 0
            if (array.Length == 0) {
                return 0;
            }
            
            // Массив, длинной на один меньше
            double[] new_array = new double[array.Length - 1];
            
            // Заполняем массив
            for (int i=0; i < new_array.Length; ++i) {
                new_array[i] = array[i];
            }

            // Приплюсовываем к результату тот самый вырезанный элемент и передаем в функцию уже порезанный массив
            return array[array.Length - 1] + Sum(new_array);
        }

        // 5-я задача
        static int NOD (int a, int b) {
            if (a == 0 || b == 0) {
                return a + b;
            }
            if (a > b) {
                return NOD(a - b, b);
            }
            return NOD(a, b - a);
        }

        // 6-я задача
        public static bool Palindrome(string str) {
            if (str.Length == 1) {
                return true;
            }

            if (str[0] == str[str.Length - 1]) {
                return Palindrome(str.Substring(1, str.Length - 2));
            }
            return false;
        }

        // 7-я задача
        public static void HanoiTowers(int x, char a, char b, char c) {
            // x - количество колец; a, b, c - башни
            if (x == 1) {
                Console.WriteLine($"Переместить кольцо 1 с {a} на {b}");
                return;
            }
            HanoiTowers(x - 1, a, c, b);
            Console.WriteLine($"Переместить кольцо {x} с {a} на {b}");
            HanoiTowers(x - 1, c, b, a);
        }

        // 8-я задача
        public static void IterateSubsets(int[] set, int idx = 0, string subset = "") {
            int x = set.Length;

            if (idx == x) {
                Console.WriteLine("{" + subset.TrimEnd(',') + "}");
                return;
            }

            IterateSubsets(set, idx + 1, subset);
            IterateSubsets(set, idx + 1, subset + set[idx] + ",");
        }

        // 10-я задача
        public static void GetPermutations(int[] collection, int[] permutation = null, bool[] used = null, int depth = 0) {
            if (permutation == null) {
                permutation = new int[collection.Length];
            }
            if (used == null) {
                used = new bool[collection.Length];
            }

            if (depth == collection.Length) {
                foreach (int elem in permutation) {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
                return;
            }

            for (int i = 0; i < collection.Length; ++i) {
                if (used[i] == false) {
                    permutation[depth] = collection[i];

                    used[i] = true;
                    GetPermutations(collection, permutation, used, depth + 1);
                    used[i] = false;
                }
            }
        }
    }
}
