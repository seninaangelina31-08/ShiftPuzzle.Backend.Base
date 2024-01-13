namespace PracticeAB;

class Program
{

    
    // Творим тут


    //1
    static int Add(int a, int b)
{
    return a + b;
}

    // //2
    public bool IsEven(int number)
{
return number % 2 == 0;
}


    // 
    // 

    // //3
    // static Task3()
    // {
string ReverseString(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
    // }

    // //4
    // static Task4()
    // {
public static int FindMax(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] > max)
{
    max = arr[i];
}
}
return max;
}
    // }

    // // 5
    // static Task5()
    // {
        public double CalculateYearlySalary(double salary)
        {
            return salary * 12;
            }
    // }

    // // 6
    // static Task6()
    // {
        public static double CelsiusToFahrenheit(double celsius)
{
    return celsius * 9/5 + 32;
}


    // }

    // //7
    // static Task7()
    // {
        public int CountVowels(string s)
{
    string vowels = "аиоуеэАИОУЕЭ";
    int count = 0;
    foreach(char c in s)
{
    if(vowels.Contains(c))
{
    count++;
}
}
return count;
}

    // }

    // //8
    // static Task8()
    // {
        using System;

public class Program
{
    public static int GeneratePassword(string passtohack)
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
    
    public static void Main()
    {
        string password = "1234";
        int attempts = GeneratePassword(password);
        Console.WriteLine("Потребовалось {0} попыток для взлома пароля.", attempts);
    }
}


    // }

    static void Main(string[] args)
    {
        // это функция мейн которая вызывает все отсальные функции для практики А и Б
        //вызов первой функци.... и т.п.
        Console.WriteLine(Task1(1, 2));

    }
    public static int Task1(int a, int b){
        return (a + b);
    }
}
