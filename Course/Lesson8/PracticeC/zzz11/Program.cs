namespace zzz11;

//1
public int sum(int a, int b)
{
    return a + b;
}

//2
public bool IsEven(int number)
{
    return number % 2 == 0;
}

//3
public string ReverseString(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}


//4
public int FindMax(int[] arr)
{
    return arr.Max();
}


//5
public int Factorial(int salary)
{
    return salary * 12;
}



//6
public double CelsiusToFahrenheit(double celsius)
{
    return celsius * 9/5 + 32;
}
