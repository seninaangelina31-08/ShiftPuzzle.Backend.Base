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

string[] array_8 = {"0", "1", "2", "asd"};
void Perebor(string[] array)
{
    int[] count = new int[1];
    void Recursiv_8(string[] array, int[] count, string str_copy = "", string str_copy_Kostil = "", int i = 0)
    {
        if (count.Length >= array.Length)
        {
            // Console.WriteLine("EXIT");
            return;
        }
        if (count[0] >= array.Length && count.Length < (array.Length - 1))
        {
            // Console.WriteLine("IF 1");
            Array.Resize(ref count, count.Length + 1);
            for (int k = 0; k < count.Length; k++)
            {
                count[k] = k;
            }
        }
        if (i >= count.Length)
        {
            // Console.WriteLine("IF 2");
            count[count.Length - 1]++;
            i = 0;
        }
        if (count[i] >= array.Length && i != 0)
        {
            // Console.WriteLine("IF 3");
            count[i] = 0;
            count[i - 1]++;
        }
        for (int k = 0; k < count.Length; k++)
        {
            if (count[k] >= array.Length && k != 0)
            {
                // Console.WriteLine("IF 4");
                count[k - 1]++;
                count[k] = count[k - 1] + 1;
            }
            if (count[0] >= array.Length && count.Length < array.Length)
            {
                // Console.WriteLine("IF 5");
                Array.Resize(ref count, count.Length + 1);
                for (int j = 0; j < count.Length; j++)
                {
                    count[j] = j;
                }
            }
        }
        if (str_copy == "")
        {
            // Console.WriteLine("IF 6");
            foreach (int arr in count)
            {
                // Console.WriteLine("TEX: " + arr);
                if (arr < array.Length){
                // Console.WriteLine("IF 7");
                str_copy += array[arr];
                }
                else{
                    // Console.WriteLine("IF 8");
                    return;
                }
            }
            if (str_copy != str_copy_Kostil) Console.WriteLine(str_copy);
        }
        Recursiv_8(array, count, "", str_copy, i + 1);
    }
    Recursiv_8(array, count);
}
Perebor(array_8);

int[] array_9 = {1, 2, 4, 6, 1, 2, 1, 10 , 123, 0};
int[] Copy(int[] array)
{
    int[] array_copy = new int[array.Length];
    int[] Recursiv_9(int[] array, int[] array_copy, int i = 0)
    {
        if (i >= array.Length) return array_copy;
        array_copy[i] = array[i];
        return Recursiv_9(array, array_copy, i + 1);
    }
    return Recursiv_9(array, array_copy);
}
// foreach (int arr in Copy(array_8))
// {
//     Console.WriteLine(arr);
// }

void Perestanovka(string[] array)
{
    int[] count = new int[array.Length];
    string str = "";
    void Recursiv_10(string[] array, int[] count, string str, int i = 0, bool test = true)
    {
        if (count[0] >= array.Length)
        {
            Console.WriteLine();
        }
        else
        {
            if (i >= count.Length)
            {
                count[i - 1]++;
                i = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    for (int k = 0; k < str.Length; k++)
                    {
                        if (str[j] == str[k] && j != k) test = false;
                    }
                }
                if (test) 
                {
                    Console.WriteLine(str);
                }
                str = "";
            }
            if (i != (count.Length - 1) && count[i + 1] >= count.Length)
            {
                count[i + 1] = 0;
                count[i]++;
            }
            if (count[i] >= count.Length && i != 0)
            {
                count[i] = 0;
                count[i - 1]++;
            }
            if (count[0] >= count.Length)
            {
                return;
            }
            str += array[count[i]];
            Recursiv_10(array, count, str, i + 1);
        }
    }
    Recursiv_10(array, count, str);
}
// string[] array_10 = {"0", "1", "2", "3"};
// Perestanovka(array_10);