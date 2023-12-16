namespace TasksA;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public bool IsEven(int number)
    {
        return number % 2 == 0;
    }   

    public string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public int FindMax(int[] arr)
    {
        return Array.Max(arr);
    }

    public double Factorial(double salary)
    {
        return salary * 12;
    }
}

{
    public double CelsiusToFahrenheit(double celsius)
    {
        return celsius * 9 / 5 + 32;
    }

    public int CountVowels(string s)
    {
        string vowels = "аиоуеэАИОУЕЭ";
        return s.Count(c => vowels.Contains(c));
    }

    public int GeneratePassword(string passToHack)
    {
        int count = 0;
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                for (int z = 0; z < 10; z++)
                {
                    for (int h = 0; h < 10; h++)
                    {
                        count++;
                        string generatedPass = $"{x}{y}{z}{h}";
                        if (generatedPass == passToHack)
                        {
                            Console.WriteLine("Ура! Вы взломали пароль. Теперь вы хакер!");
                            return count;
                        }
                    }
                }
            }
        }
        return count;
    }
}
