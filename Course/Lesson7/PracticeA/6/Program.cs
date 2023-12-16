namespace _6;

class Program
{
    static void Main(string[] args)
{
            Console.WriteLine("Введите строку для проверки на палиндром:");
            string bimbumbam = Console.ReadLine();

            bool palindrome = IsPalindrome(bimbumbam.ToLower());

            if (palindrome)
            {
                Console.WriteLine($"Строка \"{bimbumbam}\" является палиндромом.");
            }
            else
            {
                Console.WriteLine($"Строка \"{bimbumbam}\" не является палиндромом.");
            }
        }

        static bool IsPalindrome(string stroka)
        {
            if (stroka.Length <= 1)
                return true;

            if (stroka[0] == stroka[stroka.Length - 1])
            {
                return IsPalindrome(stroka.Substring(1, stroka.Length - 2));
            }

            return false;
    }
}