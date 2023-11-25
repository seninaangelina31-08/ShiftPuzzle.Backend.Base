namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте! Я могу вычислить Ваш возраст! Для это введите свой год рождения! ");
        int age = 2023 - Convert.ToInt16(Console.ReadLine());
         Console.WriteLine("Вам " + age + " лет");
    }
}
