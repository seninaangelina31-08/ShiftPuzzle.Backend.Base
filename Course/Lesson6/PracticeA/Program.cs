int Summa(int a, int b)
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





