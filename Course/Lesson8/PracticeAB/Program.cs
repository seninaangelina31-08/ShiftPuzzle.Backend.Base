using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeAB {
    class Program 
    {
        // 1
        public static int Task1(int a, int b) {
            return (a + b);
        }

        // 2
        public static bool Task2(int number) {
            return number % 2 == 0;
        }

        // 3
        public static string Task3(string s) {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 4
        public static int Task4(int[] array){
            return array.Max();
        }

        // 5
        public static int Task5(int sallary) {
            return sallary * 12;
        }

        // 6
        public static double Task6(double celsius) {
            return celsius * 9 / 5 + 32;
        }

        // 7
        public static int Task7(string s) {
            int counter = 0;
            string vowels = "аиоуеэАИОУЕЭ";
            foreach (char c in s) {
                if (vowels.Contains(c)) {
                    ++counter;
                }
            }
            return counter;
        }

        // 8
        public static int Task8(string passtohack) {
            int count = 0;
            string generatedpass;
            for (int x = 0; x < 10; ++x) {
                for (int y = 0; y < 10; ++y) {
                    for (int z = 0; z < 10; ++z) {
                        for (int h = 0; h < 10; ++h) {
                            count += 1;
                            generatedpass = Convert.ToString(x) + Convert.ToString(y) + Convert.ToString(z) + Convert.ToString(h);
                            if (generatedpass  == passtohack) {
                                Console.WriteLine("Ура! Вы взломали пароль теперь вы хакер");
                                return count;
                            }
                        }
                    }
                }
            }
            // Оно что-то ругается, если count здесь не пррописать
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Task1(1, 2));
            Console.WriteLine(Task2(2)); 
            Console.WriteLine(Task3("Строка"));
            int[] array = {1, 100, 2, 3, 5, 0, 10};
            Console.WriteLine(Task4(array)); 
            Console.WriteLine(Task5(60000));
            Console.WriteLine(Task6(100)); 
            Console.WriteLine(Task7("Строка"));
            Console.WriteLine(Task8("9999")); 
        }
    }

}