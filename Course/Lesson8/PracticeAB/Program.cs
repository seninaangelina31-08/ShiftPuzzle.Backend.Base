namespace PracticeAB;

class Program
{

    
    // Творим тут


    //1
    public static int add( int a, int b)
    {
        return a + b;
    }


    //2
    public static bool is_even(int number)
    {
        return number % 2 == 0;
    }


    //3
    public static string reverse_string( string s )
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }


    //4
    public static int find_max( int[] mass )
    {
        return mass.Max();
    }


    // 5
    public static int factorial( int sallary )
    {
        return sallary * 12;
    }

    // 6
    public static double celsius_to_fahrenheit(int celsius)
    {
        return celsius * 9/5 + 32;
    }


    //7
    public static int count_vowels(string s)
    {
        int sum = 0;
        string vowels = "аиоуыеэАИОУЫЕЭ";
        foreach (char c in s)
        {
            foreach (char d in vowels)
            {
                if (c == d)
                {
                    sum ++;
                }
            }
        }
        return sum;
    }


    //8
    public static void generate_password(string passtohack)
    {
        int count = 0;
        for (int x=0; x<10; x++)
        {
            for (int y=0; y<10; y++)
            {
                for (int z=0; z<10; z++)
                {
                    for (int h=0; h<10; h++)
                    {
                        count += 1;
                        string generatedpass = x.ToString() + y.ToString() + z.ToString() + h.ToString();
                        if (generatedpass  == passtohack)
                        {
                            Console.WriteLine("Ура! Вы взломали пароль теперь вы хакер. Вы смогли взломать пароль за " + count + " попытки");
                        }
                    }
                }
            }
        }   
    }



    static void Main(string[] args)
    {
        //1
        Console.WriteLine("The sum is " + add(4, 3));

        //2
        bool s = is_even(3);
        if (s == false){
            Console.WriteLine("No");
        }
        else{
            Console.WriteLine("Yes");
        }

        //3
        Console.WriteLine("The reversed string is " + reverse_string("werweret"));

        //4
        int [] mass = [2, 45, 23, 235, 53235223, 123123123, 345345, 23];
        Console.WriteLine("The biggest number is " + find_max( mass ));

        //5
        Console.WriteLine("Year salary = " + factorial( 30000 ));

        //6
        Console.WriteLine(celsius_to_fahrenheit(25) + " degree by fahrenheit");

        //7
        Console.WriteLine("In this string " + count_vowels("ыыыыы") + " vowels");

        //8
        generate_password("3453");
    }
}
