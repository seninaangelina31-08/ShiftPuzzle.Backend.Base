namespace Task3;

class Program
{
    static void Main(string[] args)
    {
        string[] names = [];
        string[] numbers = [];


        Console.WriteLine("Привет! С помощью этой программы ты сможешь сохранить имена людей и номера телефонов!");
        Console.WriteLine("Готов вводить данные? (да/нет)");

        string answer1 = Console.ReadLine();

        if (answer1 == "да")
        {
            Console.WriteLine("Отлично! Введи имя контакта: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("Введи его номер телефона: ");
            string number = Console.ReadLine();

            Console.WriteLine("Контакт в записной книжке:");
            Console.WriteLine(name + ": " + number);

            // if (names.Contains(name) && numbers.Contains(number))
            // {
            //     Console.WriteLine("Контакт уже существует");

            // }

            // else
            // {
            //     names.Append(name);
            //     numbers.Append(number);
            // }
        }

        else if (answer1 == "нет")
        {
            Console.WriteLine("Хорошо. Как будешь готов, выбирай ответ: да!");
        }

        else
        {
            Console.WriteLine("Ты опечатался :( ");
        }
    }
}
