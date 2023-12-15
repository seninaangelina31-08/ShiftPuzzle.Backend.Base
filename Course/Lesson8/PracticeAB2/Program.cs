namespace PracticeAB2;

class Program
{
    // Задание 1

    public static int Task1(int a, int b){
        return (a + b);
    }

    // Задание 2

    public static bool Task2(int a){
        if (a % 2 == 0){
            return true;
        }
        return false;
    }

    // Задание 3

    public static string Task3(string word){
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return string.Join("", charArray);
    }

    // Задание 4
    public static int Task4(int[] arr){
        int max_num = arr.Max();
        return max_num;
    }

    // Задание 5
    public static int Task5(int a){
        return a*12;
    }

    // Задание 6
    public static double Task6(int cels){
        return ((cels * 9/5) + 32);

    }

    // Задание 7
    public static int Task7(string s){
        string vowels = "AaOoYyUuIiEe";
        char[] vowels_ar = vowels.ToArray();
        char[] chars = s.ToArray();
        int counter = 0;
        for (int i = 0; i < s.Length; i++){
            for (int j = 0; j < vowels_ar.Length; j++){
                if (s[i] == vowels_ar[j]){
                    counter++;
                }
            }
        }
        return counter;
    }

    // Задание 8
    public static int Task8(string truepassword){
        int counter = 0;
        for (int f = 0; f < 10; f++){
            for (int s = 0; s < 10; s++){
                for (int t = 0; t < 10; t++){
                    for (int c = 0; c < 10; c++){
                        counter++;
                        string pass = Convert.ToString(f) + Convert.ToString(s) + Convert.ToString(t) + Convert.ToString(c);
                        if (pass == truepassword){
                            return counter - 1;
                        }
                    }
                }
            }
        }
        return 123;
    }
    static void Main(string[] args)
    {
        // это функция мейн которая вызывает все отсальные функции для практики А и Б
        //вызов первой функци.... и т.п.
        int[] array_nums = {1, 5, 23, 2, 24, 36, 23, 35};

        Console.WriteLine(Task1(1, 2));
        Console.WriteLine(Task2(67));
        Console.WriteLine(Task3("Pineapple"));
        Console.WriteLine(Task4(array_nums));
        Console.WriteLine(Task5(12000));
        Console.WriteLine(Task6(45));
        Console.WriteLine(Task7("Hello world"));
        Console.WriteLine(Task8("8716"));
    }
}
