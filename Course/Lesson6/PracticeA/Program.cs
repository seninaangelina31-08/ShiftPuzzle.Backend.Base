int sum(int x, int y)
{
    return x + y;
}

void Hello(string name)
{
    Console.WriteLine("Привет, " + name + '!');
}
Hello("Никита");

int max(int x, int y)
{
    if (x > y) {return x;}
    else {return y;}
}

bool chetno(int x)
{
    if (x % 2 == 0) {return true;}
    else {return false;}
}

double Convert_Temp(double t)
{
    return (t * 1.8 + 32.0);
}

string Reverse_str(string str)
{
    char[] chars = str.ToCharArray();
    Array.Reverse(chars);
    return new string(chars);
}

int Count_char(string str, char char_need)
{
    char[] chars = str.ToCharArray();
    int count = 0; 
    foreach (char arr in chars)
    {
        if (arr == char_need)
        {
            count++;
        }
    }
    return count;
}

int factorial(int x)
{
    int summ = 0;
    for (int i = 0; i <= x; i++)
    {
        summ += i;
    }
    return summ;
}

bool prosto(int x)
{
    for (int i = 2; i < x; i++)
    {
        if (x % i == 0)
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine(prosto(2));

int Random_DIA(int x, int y)
{
    Random r = new Random();
    return r.Next(x, y);
}