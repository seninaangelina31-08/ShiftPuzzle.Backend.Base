namespace PracticeC;
class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (true)
        {
            Console.Write("Введите + если хотите добавить новый конткт, = если хотите вывести списко контактов, любой другой симовл если хотите выйти: ");
            string a = Console.ReadLine() ?? "";
            var people = new Dictionary<string, string>();
            if (a == "+")
            {
                i++;
                Console.Write($"Введите имя {i}-го контакта: ");
                string name = Console.ReadLine() ?? "";
                Console.Write($"Введите номер {i}-го контакта: ");
                string ph_number = Console.ReadLine() ?? "";
                Console.WriteLine(name + " " + ph_number);
                people.Add(ph_number, name);
                Console.WriteLine(people.TryAdd(ph_number, name)); // Проверка
                people.Add("89601740908", "Юра");
                Console.WriteLine(people.TryAdd("89601740908", "Юра")); // Проверка
            }
            else if (a == "=")
            {
                foreach(var person in people)
                {
                    Console.WriteLine($"{person.Value} : {person.Key:# (###) ###-##-##}");
                    Console.WriteLine("4"); // вывод для проверки входа в цикл
                }
                
            }
            else
            {
                break;
            }
        }
    }
}
