namespace PracticeAB;

class Program
{
// Запуск функций
    static void Main(string[] args)
    {
int[] mass = {1, 2, 3, 4, 5, 6, 7, 8};
Console.WriteLine(Sum(2,2));
Console.WriteLine(Chet_num(3));
Console.WriteLine(String_rev("Pumba"));
Console.WriteLine(Max_number(mass));
Console.WriteLine(Salary(70000));
Console.WriteLine(Celsius_to_fahrenheit(25));
Console.WriteLine(Count_vowels("bananananananaaa"));
Console.WriteLine(Generate_password("102102"));
    }

//1  
static int Sum( int a, int b)
{
    return a + b;
}

//2
static bool Chet_num(int a)
{
    if (a % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }

}

//3
static string String_rev(string a)
{
char[] charArray = a.ToCharArray();
Array.Reverse(charArray);
return new string(charArray);

}

//4
static int Max_number(int[] array )
{
int num = array.Max();
return num;
}
//5
static int Salary(int a)
{
    int ans = a * 12;
    return ans;
}
//6
static int Celsius_to_fahrenheit(int a)
{
    return a * 9/5 + 32;
}

static int Count_vowels(string s)
{
    char a = 'a';
    int ans = 0;
    foreach( int i in s)
    {
    if (i == a)
    {
        ans++;
    }
    }
    return ans;
}

static int Generate_password(string passtohack)
{
    int count = 0;
    for (int x = 0; x <= 10; ++x )
    {
        for (int y = 0; y <= 10; ++y )
        {
            for ( int z = 0; z <= 10; ++z)
            {
                for ( int h = 0; h <= 10; ++h)
                {
                count++;
                string generatedpass = x.ToString() + y.ToString() + z.ToString() + h.ToString();
                if (generatedpass == passtohack)
                {
                    Console.WriteLine("Your MotherHaker!!!");
                    return count;
                }
                }
            }
        }
    }
}






}
