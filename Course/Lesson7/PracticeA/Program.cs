int Factorial(int n)
{
    if (n <= 1)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n-1);
    }
}

int Fibanachi(int n, int k = 1, int f0 = 0, int f1 = 1)
{
    if (n <= k)
    {
        return f1;
    }
    return Fibanachi(n, (k + 1), f1, (f1 + f0));
}
// Console.WriteLine(Fibanachi(10));

string Reverse(string str, string str_reverse = "", int k = 0)
{
    if (k >= str.Length)
    {
        return "";
    }
    str_reverse = str_reverse + Convert.ToString(str[str.Length - k - 1]);
    k++;
    return str_reverse[k -1] + Reverse(str, str_reverse, k) ;
}
// string str = "Hello!";
// Console.WriteLine(Reverse(str));


int Sum(int[] array, int i = 0)
{
    if (i >= array.Length)
    {
        return 0;
    }
    return array[i] + Sum(array, i + 1);
}
// int[] array = {1, 2, 3, 4, 5};
// Console.WriteLine(Sum(array));

int NOD(int x, int y)
{
    if (x < y)
    {
        y -= x;
    }
    else if (x > y)
    {
        x -= y;
    }
     else
    {
        return x;
    }
    return NOD(x, y);
}
// Console.WriteLine(NOD(8, 4));

bool Paledrom(string str, int i = 0, bool flag = false)
{
    str = str.ToLower();
    if (str.Length != 0)
    {
        if (i < (str.Length / 2) && str[i] == str[(str.Length - 1 - i)])
        {
            flag = true;
            Paledrom(str, (i + 1), flag);
        }
        else if (i < (str.Length / 2) && str[i] != str[(str.Length - 1 - i)])
        {
            flag = false;
        }
    }
    return flag;
}
// Console.WriteLine(Paledrom("AFa"));

int Hanoisk(int n, int i = 0, int sum = 1)
{
    if (i >= n)
    {return sum - 1;}
    sum *= 2;
    return Hanoisk(n, i + 1, sum);
}
// Console.WriteLine(Hanoisk(8));

// void Perebor(int[] array, int i = 0, int end = 1, int length_01)

void f(int[] arr, int i = 0)
{
    if (i >= arr.Length)
    {
        Console.WriteLine();
        return;
    }
    Console.Write(i);
    i++;
    f(arr, i);
}
int[] array = {3, 3};
f(array);