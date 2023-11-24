namespace Task5;
class Program
/***5.Сохранение и вывод текста:**
Попросите пользователя ввести какой-то текст в переменную и затем выведите этот текст на экран.*/
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Введите текст!");
            Console.WriteLine("Результат: " + Console.ReadLine());
            Console.WriteLine();
        }
    }
}
