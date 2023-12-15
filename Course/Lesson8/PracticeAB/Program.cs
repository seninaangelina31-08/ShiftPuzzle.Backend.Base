namespace PracticeAB;

class Program
{

    
    // Творим тут


    // 1
    public static int Task1(int a, int b){
        return (a + b);
    }

    // 2
    
    public static bool Task2(int a){
        return a % 2 == 0;

    // 3

    static string Task3(string str){
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return string.Join("", charArray);
    }

    // 4
    static int Task4(int[] arr){
        return arr.Max();
    }

    // 5
    static int Task5(int a){
        return a * 12;
    }

    // 6
    static double Task6(int cels){
        return cels / 5 * 9 + 32;

    }

    // 7
    static int Task7(string s){
        string vowels = "УуЕеЭэОоАаЫыЯяИиЮю";
        char[] vowels_ar = vowels.ToArray();
        char[] chars = s.ToArray();
        int cnt = 0;
        foreach (char c in chars)
        {
            foreach (char gl in vowels)
            {
                if (c == gl){
                    cnt++;
                    break;
                }
            }
        }
        return cnt;
    }

    // 8
    static int Task8(string truepassword){
        int cnt = 0;
        for (int f = 0; f < 10; f++){
            for (int s = 0; s < 10; s++){
                for (int t = 0; t < 10; t++){
                    for (int c = 0; c < 10; c++){
                        cnt++;
                        string pass = Convert.ToString(f) + Convert.ToString(s) + Convert.ToString(t) + Convert.ToString(c);
                        if (pass == truepassword){
                            Console.WriteLine("Ура! Вы взломали пароль теперь вы хакер");
                            return cnt;
                        }
                    }
                }
            }
        }
    }

    static void Main(string[] args)
    {
        // это функция мейн которая вызывает все отсальные функции для практики А и Б
        //вызов первой функци.... и т.п.
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
}