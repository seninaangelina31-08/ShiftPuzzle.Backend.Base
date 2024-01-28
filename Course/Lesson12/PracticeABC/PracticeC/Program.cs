namespace PracticeAB;

class Program
{

    
    // Творим тут

<<<<<<< HEAD
    //1
    public static int add(int a, int b){
         return (a + b);
    }
    //def add(a, b):
    //return a + b
    
    // //2
    // static Task2()
    //# Задача 2: Функция проверки четности
    //def is_even(number):
    //return number % 2 == 0
        public static bool is_even(int number)
    {
        return number % 2 == 0;
    }


    // //3
    // Задача 3: Функция переворота строки
    // Подсказка: не усложняйте алгоритм
    //char[] charArray = s.ToCharArray();
    //string reversed = new string(Array.Reverse(charArray));
    // static Task3()
     public static string reverse_string(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // //4
    // static Task4()
    // Задача 4: Функция поиска максимального элемента в массиве
    // Подсказка : в С# можно получить максимальное значение так : array.Max();
    public static int find_max(int[] arr)
    {
        return arr.Max();
    }


    //  # Задача 5: Функция вычисления зарплаты за год
        // static Task5()
    public static int factorial(int sallary)
    {
        return sallary * 12;
    }

    // // 6
    // static Task6()
    //# Задача 6*: Функция конвертации температур
    public static double celsius_to_fahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    // //7
    // static Task7()
    //# Задача 7*: Функция поиска количества гласных в строке
    // Подсказа: используйте цикл foreach foreach (char c in s) где s строка для проверки а c  каждый ее символ
    // аналог in  в c# - vowels.Contains(c) где символ строки
    public static int count_vowels(string s)
    {
        string vowels = "аиоуеэАИОУЕЭ";
        int count = 0;
        
        foreach (char c in s)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        
        return count;
    }

    // //8
    // static Task8()
    //Задача 8*: Функция для опредления сложности взлома 4х значного пароля пароля
    
    public static int generate_password(string passtohack)
    {
            int count = 0;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        for (int h = 0; h < 10; h++)
                        {
                            count++;
                            string generatedpass = x.ToString() + y.ToString() + z.ToString() + h.ToString();
                            if (generatedpass == passtohack)
                            {
                                Console.WriteLine("Ура! Вы взломали пароль, теперь вы хакер");
                                return count;
                            }
                        }
                    }
                }
            }
            return count;
    }