using System;

namespace A;
public class A
{
    public static int sum(int a, int b)
    {
        int res = a + b;
        return res;
    }

    public static string Hello(string name)
    {
        string txt = "Привет, " + name + "!";
        return txt;
    }

    public static int GetMax(int num1, int num2)
    {
        if (num1 > num2)
        {
            return num1;
        }
        else
        {
            return num2;
        }
    }

    public static bool IsEven(int number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
  
        return false;
    }

    static double CelsToFar(double c)
    {
        double f = (c * 9 / 5) + 32;
        return f;
    }

    public string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }   

    public int CountCharacters(string inputString, char targetCharacter)
    {
    int count = 0;
    foreach (char character in inputString)
    {
        if (character == targetCharacter)
        {
            count++;
        }
    }
    return count;
    }

    public static int Factorial(int number)
    {
        if (number == 0 || number == 1)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }

    public bool IsPrime(int number)
    {
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
    }

    public int randomNum(int a, int b){
        Random rnd = new Random();
        return rnd.Next(a, b);
    }
}