namespace HW2;
class Program
/***2.Игра угадай число:**
Загадайте случайное число в переменной и попросите пользователя угадать это число, предоставляя подсказки (больше/меньше). */
{
    static void Main(string[] args)
    {
        var rand = new Random();
        int count;
        int temp_count;
        while(true)
        {
            Console.WriteLine("Угадайте число");
            count = rand.Next(100);
            while(true)
            {
                Console.WriteLine("Какое число");
                temp_count = int.Parse(Console.ReadLine());
                Console.WriteLine(temp_count + "Вывод");
                if(temp_count == count)
                {
                    Console.WriteLine("Верно");
                }
                else if (temp_count > count)
                {
                    Console.WriteLine("Меньше");
                    if (temp_count < count);
                      {
                          Console.WriteLine("Больше");
                      }
                }
                Console.WriteLine();
                Console.WriteLine(count + "Ответ");
            }

        }
    }
}
