<<<<<<< HEAD
﻿int Summa(int a, int b)
{
    return a + b;
}

Console.WriteLine(Summa(5, 15));


void Greetings(string name)
{
    Console.WriteLine($"Приветствую тебя {name}");
}


int MaxNumber(int a, int b)
{
    if (a < b) return b;
    else return a;
}

bool Even(int a)
{
    if (a % 2 == 0) return true;
    else return false;
}


double Faringait(int a)
{
    return a * 1.8 + 32;
}




string ReverceString(string str)
{
    string str2 = "";
    for (int i = str.Length - 1; i >= 0; i--)
    {
        str2 += str[i];
    }

    return str2;
}

int CountChars(string str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
    {
        count++;
    }

    return count;
}

int Factorial(int N)
{
    int factorial = 1;
    for (int i = 1; i <= N; i++)
    {
        factorial *= i;
    }

    return factorial;
}

bool SimpleNumber(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;

    return true;
}


int RandomNumber()
{
    Random random = new Random();
    return random.Next(1, 100);
}





=======
﻿namespace PracticeA;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Sum(5, 3));
        GreetUser("John");
        Console.WriteLine(Max(10, 20));
        Console.WriteLine(IsEven(7));
        Console.WriteLine(ConvertToFahrenheit(25));
        Console.WriteLine(ReverseString("hello"));
        Console.WriteLine(CountChars("hello", 'l'));
        Console.WriteLine(CalculateFactorial(5));
        Console.WriteLine(IsPrime(17));
        Console.WriteLine(GenerateRandomNumber(1, 100));
    }

    // Function to calculate the sum of two numbers
    static int Sum(int a, int b)
    {
        return a + b;
    }

    // Function to greet the user
    static void GreetUser(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }

    // Function to find the maximum of two numbers
    static int Max(int a, int b)
    {
        return (a > b) ? a : b;
    }

    // Function to check if a number is even
    static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    // Function to convert temperature from Celsius to Fahrenheit
    static double ConvertToFahrenheit(double celsius)
    {
        return ((celsius * 9 / 5) + 32);
    }

    // Function to reverse a string
    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Function to count the occurrences of a character in a string
    static int CountChars(string str, char ch)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == ch)
            {
                count++;
            }
        }
        return count;
    }

    // Function to calculate the factorial of a number
    static int CalculateFactorial(int num)
    {
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result = i;
        }
        return result;
    }

    // Function to check if a number is prime
    static bool IsPrime(int num)
    {
        if (num <= 1)
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

    // Function to generate a random number in a specified range
    static int GenerateRandomNumber(int min, int max)
    {
        Random rnd = new Random();
        return rnd.Next(min, max + 1);
    }
}
>>>>>>> main
