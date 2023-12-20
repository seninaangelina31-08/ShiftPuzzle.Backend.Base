// See https://aka.ms/new-console-template for more information

class Program
{
    public static int summa(int a, int b)
{
    return a+b;
}


    public static void privet(string name)
{
    Console.WriteLine("Hello, " + name);
}


    public static void max(int a, int b)
{
    if (a > b){
        Console.WriteLine(a);
    }
    else{
        Console.WriteLine(b);
    }
}


    public static bool chet(int a)
{
    if (a%2==0){
        return true;
    }
    else{
        return false;
    }
}


    public static double tempF(int tempC)
{
    return(tempC*33.8);
}


    public static string Reverse(string line )
{
    char[] array = line.ToCharArray();
    Array.Reverse(array);
    return new string(array);
}


    public static void Vhod(string str, char el)
{
        int cnt = 0;
        foreach (char c in str) {
        if (c == el) {cnt++;}
}

        Console.WriteLine(cnt);
}


    public static int Fact(int a)
{
        int n = 1;
        int fac = 1;
        while (n<=a){
            fac *= n;
            n++;
    }
        return fac;
}


    public static void Easy(int a)
{
        string answer = "Это число простое";
    
        for (int n = 1; n<a; n++){
            if (a%n==0){
                answer = "Это число не простое";
        }
    }

        Console.WriteLine(answer);
}


    public static int Random(int a,int b)
{
    Random rnd = new Random();
    var result = rnd.Next(a, b);
    return result;
}

    static void Main(string[] args)
    {
        Console.WriteLine(summa(3, 6));

        privet("Dasha");

        max(12, 4);

        Console.WriteLine(chet(23));

        Console.WriteLine(tempF(34));

        Console.WriteLine(Reverse("fghjkl"));

        Vhod("dddddd", 'd');

        Console.WriteLine(Fact(5));

        Easy(6);

        Console.WriteLine(Random(1, 5000));
    }
}


