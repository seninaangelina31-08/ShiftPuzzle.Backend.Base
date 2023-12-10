using System;
namespace PracticeA;

class Program
{

//Task 1
static int Sum( int a, int b)
{
int result = a + b;
return result;
}
//Task 2
static void Greeting(string name)
{
Console.WriteLine($"Здорово {name} !");
}
//Task 3

static int Max_number(int a, int b)
{
    if (a > b)
    {
    return a;   
    }
    else
    {
    return b;
    }
    
}
//Task 4
static int Num(int a)
{
// string t = "true";
// string f = "false";
    if ((a % 2) == 1)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}
//Task 5
static int Constructor(int a)
{
     int result = (a * 9 / 5) + 32;
    return result;
}
//Task 6
static string Perevorot(string a)
{
    char[] arr = a.ToCharArray();
    Array.Reverse(arr);
    return new String(arr);
}

//Task 7
// static int Simbol(string word)
// {
// char a = 'a';
// int var = 0;
// for (int i = 0; i < word.Length; i++)
// {
// char c = word[i];
// if (c == a)
// {
//     var++;
// }
// }
// return var;
// }

//Task 8
static int Factorial(int a)
{
    int num = 5;
    int fac = 1;
    for (int i = 1; i <= num; ++i)
    {
        fac *= i;
    }
    return fac;
}

//Task 9
static int Easy_num(int n)
{
    if (n % 2 != 0 )
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

//Task 10
static int Generator(int a, int b)
{
    Random run_num = new Random();
    int number = run_num.Next(a, b);
    return number;
}




    static void Main(string[] args)
    {
    int result = Sum(1,3);
    Console.WriteLine(result);

    string greet = "maxim";
    Greeting(greet);

    int max_num = Max_number(1,100);
    Console.WriteLine(max_num);
    
    int num = Num(101);
    Console.WriteLine(num);
    
    int conv = Constructor(10);
    Console.WriteLine("По Фарангейту это: " + conv);

    string rev = Perevorot("pazl");
    Console.WriteLine(rev);

    // string word = Simbol("banana");
    // Console.WriteLine(word);

    int fac = Factorial(5);
    Console.WriteLine(fac);

    int esnum = Easy_num(101);
    Console.WriteLine(esnum);

    int random = Generator(1,200);
    Console.WriteLine("Your IQ is: " + random);

    }
}
