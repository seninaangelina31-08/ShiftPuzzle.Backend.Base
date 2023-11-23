namespace PracticeB;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите год рождения:");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year < 2023){
            Console.WriteLine("Ваш возраст: " + (2023 - year) +  " или " + (2023 - year + 1) + " лет");
        }
        else{
            Console.WriteLine("Такого не может быть. Повторите попытку");
        }
    }
}
