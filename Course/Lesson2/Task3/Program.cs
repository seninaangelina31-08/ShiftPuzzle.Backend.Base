namespace Task3;
class Program
/***3.Записная книжка:**
Создайте программу, которая позволяет пользователю вводить и сохранять имена и телефонные номера в переменных, а затем выводить их на экран.*/
{
    static void Main(string[] args)
    {
        string names = "None";
        string numbers = "None";
        while(true)
        {
            Console.WriteLine("Изменить контакт? (да)");
            if(Console.ReadLine() == "да")
            {
                Console.WriteLine("Введите имя:");
                names = Console.ReadLine();
                Console.WriteLine("Введите номер");
                numbers = Console.ReadLine();
            }
            Console.WriteLine("Имя: " + names);
            Console.WriteLine("Номер" + numbers);
            Console.WriteLine();
        }
    }
}
