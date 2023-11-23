namespace task2;
class Program
{
    static void Main(){
        Console.WriteLine("Введите дату рождения: ");
        int year = Convert.ToInt32(Console.ReadLine());
        int age = 2023 - year;
        Console.WriteLine("Вам " + age + " лет.");
    }
}