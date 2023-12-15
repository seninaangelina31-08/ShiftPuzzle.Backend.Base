﻿namespace PracticeA;
static class Program
{
    public static int factorial(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        else
        {
            return n * factorial(n - 1);
        }
    }
        public static long fibonarchi(int n)
        {
             if (n <= 2)
            {
            return 1;
            }
            else
            {
            return fibonarchi(n - 1) + fibonarchi(n - 2);
            }
        }
        public static string obrashstroki(string str)
        {
            string copy = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                copy += str[i];
            }
            return copy;
        }
        public static int sum(int[] a, int count)
        {
            if (count > 1)
            {
                return a[count - 1] + sum(a, count - 1);
            }
            else
            {

            return a[count - 1];
            }
        }
        public static int nod(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return nod(b, a % b);
            }
        }
        public static bool palindrom(string input)
        {
            if (input.Length <= 1)
            {
                return true;
            }

            if (input[0] == input[input.Length - 1])
            {
                return palindrom(input.Substring(1, input.Length - 2));
            }

            return false;
        }

        public static void podmno(int[] a, int index = 0, string str = "")
        {
            if (index == a.Length)
            {
                Console.WriteLine("[" + str + "]");
                return;
            }

            podmno(a, index + 1, str);
            podmno(a, index + 1, str + a[index] + ",");

        }
        public static void sw(string[] array, int k = 1)
        {


            string[] tempArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[(i + k) % array.Length] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = tempArray[i];
            }
            Console.Write("");

        }
}