public int EuclideanAlgorithm(int a, int b)
{
    if (b == 0)
    {
        return a;
    }
    else
    {
        return EuclideanAlgorithm(b, a % b);
    }
}

//НОД ^


public int Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }
    else
    {
        return n * Factorial(n - 1);
    }
}

// Факториал числа ^