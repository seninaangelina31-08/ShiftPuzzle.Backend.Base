using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;


namespace PracticeA;

class Program
{
    static void Main(string[] args)
    {
        
        static int Sum(int a, int b)
        {
            return a+b;
        }

        string hello = "Hello, user!!!";

        static void Hello_user(string hello)
        {
            Console.WriteLine(Hello_user);
        }

        static int Maxn(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else{
                return b;
            }
        }

        int c = 8;
        static bool Num_chet(int c)
        {
            if (c % 2 == 2)
            {
                return true;
            }
            else{
                return false;
            }
        }

        double cels = 9;
        static double C_to_f(double cels)
        {
            return (cels * 9 / 5) + 32;
        }

        string str = "Hello";
        static string Reverse(string str)
        {
            char[] array = str.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        
        char symbol = 'l';
        static int Num_string(string str, char symbol)
        {
            byte count = 0;
            foreach(char i in str)
            {
                if (i == symbol)
                {
                    count++;
                }
            }
            return count;

        }
        int num = 5;
        static int Factorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }
            else{
                int result = 1;
                for (int i = 1; i<= num; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        static bool Prime_num(int num)
        {
            if(num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        int num2 = 13;
        static int Random_num(int num,int num2)
        {
            Random random = new Random();
            int random_num = random.Next(num,num2);
            return random_num;
        }

    }
}
