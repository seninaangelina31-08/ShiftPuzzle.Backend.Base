
namespace PracticeA;

class Program
{
    static  void Main(string[] args)
    {   //1
        int num = Convert.ToInt32(Console.ReadLine());
        int res = fact(num);
        Console.WriteLine(res);

        //2
        Console.WriteLine(fibonaci(num));

        //3
        string str = Console.ReadLine();
        Console.WriteLine(change(str));

        //4
        int[] mass = [7, 5, 765, 34, 6];
        int s = mass.Length;
        Console.WriteLine(sum(mass, s));

        //5
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(evk(a, b));

        //6
        string a = Console.ReadLine();
        Console.WriteLine(palin(a));


        //7
        int n = Convert.ToInt32(Console.ReadLine());
        char a = '1';
        char b = '2';
        char c = '3';
        tower(n, a, b, c);


        //8
        int[] mass = { 45, 2, 1, 8 };
        undermany(mass);
        
    }

    //1
    static int fact (int num)
    {
        if (num <= 1){
            return 1;
        }
        else{
            return num * fact(num - 1);
        }
    }
    
    
    //2
    static int fibonaci(int num)
    {
        if (num>1 & num<2){
            return 1;
        }
        else{
            return fibonaci(num - 1) + fibonaci(num - 2);
        }
    }


    //3
    static string change(string str)
    {
        int s = str.Length;
        if (s == 1)
        {
            return str;
        }
        else
        {
            return change(str.Substring(1)) + str[0];
        }
    }


    //4
    static int sum(int[] mass, int s)
    {
        if (s == 1)
        {
            return mass[0];
        }
        else
        {
            return mass[s-1] + sum(mass, s-1);
        }
    }


    //5
    static int evk(int a, int b)
    {
        if (a == b){
            return a;
        }

        if (a == 0){
            return b;
        }

        else{
            return evk(b%a, a);
        }
    }


    //6
    static int palin(string a)
    {
        int s = a.Length;
        if (s<2){
            return 1;
        }

        else{
            if (a[0] != a[-1]){
            return 0;
            }

            else{
                return palin(a.Substring(1, -1));
            }
        }
    }


    //7
    public static void  tower(int n, char a, char b, char c)
        {
            if (n < 2)
                Console.WriteLine("Move disk " + a.ToString() + " to colon " + c.ToString());
            else
            {
                tower(n - 1, a, c, b);
                Console.WriteLine("Move disk " + a.ToString() + " to colon " + c.ToString());
                tower(n - 1, b, a, c);
            }
        }


    //8
    public static void undermany(int[] mass, int m = 0, string s_mass = "")
    {
        if (m == mass.Length)
        {
            Console.WriteLine("Подмножество: " + s_mass);
        }

        else
        {
        undermany(mass, m + 1, s_mass + mass[m] + ", ");
        undermany(mass, m + 1, s_mass);
        }
    }

}
