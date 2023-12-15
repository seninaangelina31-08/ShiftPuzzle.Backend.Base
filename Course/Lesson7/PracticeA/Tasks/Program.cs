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
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
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
            if (array.Length == 0)
            {
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
    }
}
