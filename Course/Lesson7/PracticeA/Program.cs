int Factorial(int n)
{
    if (n == 1) return 1;
    else return Factorial(n - 1) * n;
}

int Fibonacci(int n)
{
    if (n == 1) return 0;
    if (n == 2) return 1;
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

string ReverseString(string str)
{
    if (str.Length == 0) return str;
    return ReverseString(str.Remove(0, 1)) + str[0];
}

int SumElements(int[] arr, int count)
{
    if (count >= arr.Length) return 0;
    return SumElements(arr, count + 1) + arr[count];
}

int NodEuclid(int a, int b)
{
    if (b == 0) return a;
    return NodEuclid(b, a % b);
}

bool IsPalindrome(string value)
{
    if (value.Length <= 1)
        return true;
    else
    {
        if (value[0] != value[value.Length - 1]) return false;
        else return IsPalindrome(value.Substring(1, value.Length - 2));
    }
}

void SolveHanoi(int n, char from, char to, char aux)
{
    if (n == 1)
    {
        Console.WriteLine("Двигать  кольцо 1 с {0} на {1}", from, to);
        return;
    }
    SolveHanoi(n - 1, from, aux, to);
    Console.WriteLine("Двигать кольцо {0} с {1} на {2}", n, from, to);
    SolveHanoi(n - 1, aux, to, from);
}


void GenerateSubsets(List<int> set, int index, List<int> currentSubset)
{
    if (index == set.Count)
    {
        Console.Write("{ ");
        foreach (var item in currentSubset)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("}");
    }
    else
    {
        GenerateSubsets(set, index + 1, currentSubset);
        currentSubset.Add(set[index]);
        GenerateSubsets(set, index + 1, currentSubset);
        currentSubset.RemoveAt(currentSubset.Count - 1);
    }
}

// List<int> set = new List<int> {1, 2, 3};
// List<int> currentSubset = new List<int>();
// GenerateSubsets(set, 0, currentSubset);

void Permute(string str, int l, int r)
{
    if (l == r)
        Console.WriteLine(str);
    else
    {
        for (int i = l; i <= r; i++)
        {
            str = Swap(str, l, i);
            Permute(str, l + 1, r);
            str = Swap(str, l, i); // backtrack
        }
    }
}

string Swap(string a, int i, int j)
{
    char temp;
    char[] charArray = a.ToCharArray();
    temp = charArray[i];
    charArray[i] = charArray[j];
    charArray[j] = temp;
    string s = new string(charArray);
    return s;
}

// string str = "ABC";
// Permute(str, 0, str.Length - 1);

