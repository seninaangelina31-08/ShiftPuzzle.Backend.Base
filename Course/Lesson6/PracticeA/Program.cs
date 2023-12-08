using System.Security.Cryptography;

namespace PracticeA;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    static public int sum(int a, int b) {
        return a+b;        
    }

    static public void hello(string s) {
        Console.WriteLine("Привет "+s+" !!!");
    }

    static public int max(int a, int b) {
        if (a > b) {
            return a;
        } else {
            return b;
        }
    }

    static public bool even(int a) {
        if (a % 2 == 0) {
            return true;
        } else {
            return false;
        }
    }

    static public float far(int a) {
        return ((float)(a*(1.8)))+(32);
    }

    static public string reverse(string s) {
        string s1 = "";
        for (int i = s.Length-1; i <=0; i--) {
            s1 = s1+s[i];
        }
        return s1;
    }

    static public int find(string s, char check) {
        int cnt = 0;
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == check) {
                cnt++;
            }
        }
        return cnt;
    }

    static public long factorial(int a) {
        long cnt = 1;
        for (int i = 2; i <a+1; i++) {
            cnt *=i;
        }
        return cnt;
    }
    
    static public bool IsPrime(int num) {
        if (num < 2) {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(num); i++) {
            if (num % i == 0) {
                return false;
            }
        }
        return true;
    }

    static public int rand(int a, int b) {
        Random rnd = new Random();
        return rnd.Next(a, b);
    }

}
