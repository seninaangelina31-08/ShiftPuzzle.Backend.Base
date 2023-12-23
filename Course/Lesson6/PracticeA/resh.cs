namespace LessonProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int t1 = sum(1,4);
            string t2 = print("meow");
            int t3 = maximum(4,8);
            bool t4 = amm(12);
            double t5 = cels(4);
            string t6 = chet("meow");
            int t7 = count("Show must go on", 'o');
            int t8 = recurs(5);
            bool t9 = prost(11);
            int t10 = rand(1,4);
            Console.WriteLine(t1);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
        }
        
    
        //1. **Функция Суммы**
    //- Напишите функцию, которая принимает два числа и возвращает их сумму.
        public static int sum(int a, int b)
        {
            int m=a+b;
            Console.WriteLine(m);
            return m;

        }

        public static string print(string message)
        {
            Console.WriteLine(message);
            return message;
        }

        //  **Функция Приветствия**
        //   - Создайте функцию, которая принимает имя пользователя и выводит приветствие с его именем.

        
        //  **Функция Максимума**
        //    - Разработайте функцию, которая принимает два числа и возвращает большее из них.
        public static int maximum(int a, int b)
        {
            int max = 0;
            if (a>b){
                max=a;
            }
            else{
                max=b;
            }
            return max;
        }

        //  **Функция Проверки Четности**
        //    - Напишите функцию, которая проверяет, является ли число четным, и возвращает `true` или `false`.
        public static bool amm(int a)
        {
            bool chet = a == 0;
            return chet;
        }
        
        //  **Функция Конвертации Температуры**
        //    - Создайте функцию, которая конвертирует температуру из Цельсия в Фаренгейт.

        public static double cels(int c)
        {
            double F =(c*1.8)+32;
            return F;
        }

        //  **Функция Обратной Строки**
        //    - Напишите функцию, которая принимает строку и возвращает её в обратном порядке.
        public static string chet(string obr)
        {
            char[] rev = obr.Reverse().ToArray();
            string a = new string(rev);
            return a;
        }


        //  **Функция Подсчета Символов**
        //    - Создайте функцию, которая подсчитывает количество определенных символов в строке.
        
        public static int count(string str, char b)
        {
            int i = 0;
            foreach (char c in str)
            {
                if (c == b)
                {
                    i++;
                }
            }
            return i;
        }
        


        //  **Функция Расчета Факториала**
        //   - Разработайте функцию, которая вычисляет факториал заданного числа.
        public static int recurs(int c)
        {
            if (c<=1)
            {
                return 1;
            }
            else{
                return c*recurs(c-1);
            }

        }


        // **Функция Проверки Простого Числа**
        //    - Напишите функцию, которая определяет, является ли число простым.
        public static bool prost(int n)
        {
            if (n<= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;

        }

        //  **Функция Генерации Случайного Числа**
        //     - Создайте функцию, которая генерирует и возвращает случайное число в заданном диапазоне.
        public static int rand(int c, int b)
        {
            Random random = new Random();
            int randnumb = random.Next(c, b+1);
            return randnumb;
            

        }

    }
}