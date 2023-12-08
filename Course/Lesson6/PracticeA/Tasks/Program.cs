using System;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 1-я задача ---");
            Console.WriteLine(Sum(3, 5));
            Console.WriteLine(Sum(2, -2));
            Console.WriteLine(Sum(2.5, 3.5));

            Console.WriteLine("--- 2-я задача ---");
            Console.WriteLine(Greet("C#"));
            Console.WriteLine(Greet("No name"));
            Console.WriteLine(Greet("братюня"));

            Console.WriteLine("--- 3-я задача ---");
            Console.WriteLine(Max(5, -5));
            Console.WriteLine(Max(5, 6));
            Console.WriteLine(Max(100, 100));

            Console.WriteLine("--- 4-я задача ---");
            Console.WriteLine(IsEven(0));
            Console.WriteLine(IsEven(2));
            Console.WriteLine(IsEven(5));

            Console.WriteLine("--- 5-я задача ---");
            Console.WriteLine(ToFahrenheit(0));
            Console.WriteLine(ToFahrenheit(32));
            Console.WriteLine(ToFahrenheit(100));

            Console.WriteLine("--- 6-я задача ---");
            Console.WriteLine(StringReverse("Строка"));
            Console.WriteLine(StringReverse("No Python"));
            Console.WriteLine(StringReverse("Only C#"));

            Console.WriteLine("--- 7-я задача ---");
            Console.WriteLine(Count("Строка", 'о'));
            Console.WriteLine(Count("Строка", ')'));
            Console.WriteLine(Count("777", '7'));

            Console.WriteLine("--- 8-я задача ---");
            Console.WriteLine(Factorial(1));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(Factorial(10));
            
            Console.WriteLine("--- 9-я задача ---");
            Console.WriteLine($"1: {IsPrime(1)}");
            Console.WriteLine($"20: {IsPrime(20)}");
            Console.WriteLine($"11: {IsPrime(11)}");

            Console.WriteLine("--- 10-я задача ---");
            Console.WriteLine(Random(1, 2));
            Console.WriteLine(Random(0, 10));
            Console.WriteLine(Random(50, 100));
        }

        // 1-я задача
        static double Sum(double a, double b) {
            return a + b;
        }

        // 2-я задача
        static string Greet(string name) {
            return $"Приветик, {name}!!!";
        }

        // 3-я задача
        static double Max(double a, double b) {
            if (a > b) {
                return a;
            }
            return b;
        }

        // 4-я задача
        static bool IsEven(double number) {
            return number % 2 == 0;
        }

        // 5-я задача
        static double ToFahrenheit(double temperature) {
            return 1.8 * temperature + 32;
        }

        // 6-я задача
        static string StringReverse(string base_string) {
            char[] string_array = base_string.ToCharArray();
            Array.Reverse(string_array);
            return new string(string_array);
        }

        // 7-я задача
        static int Count(string target_string, char target_char) {
            int counter = 0;
            foreach (char current_char in target_string) {
                if (current_char == target_char) {
                    ++counter;
                }
            }
            return counter;
        }

        // 8-я задача
        static double Factorial(double number) {
            if (number <= 0) {
                return 1;
            }
            return number * Factorial(number - 1);
        }

        // 9-я задача
        static bool IsPrime(double number) {
            bool prime = number > 1 && (number % 2 != 0 || number == 2) && (number % 3 != 0 || number == 3);
            double i = 5;
            double n = 2;

            while (prime && Math.Pow(i, 2) <= number) {
                prime = number % i != 0;
                i += n;
                n = 6 - n;
            }
                
            return prime;
        }

        // 10-я задача
        static int Random(int a, int b) {
            Random rnd = new Random();
            int random_number = rnd.Next(a, b);

            return random_number;
        }
    }

}
