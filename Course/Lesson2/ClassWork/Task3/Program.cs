namespace Task3;
class Program
{
    static void Main(string[] args)
    {
        List<Contact> phoneBook = new List<Contact>();

        inputPhoneBookFromConsole(phoneBook);

        outputPhoneBookToConsole(phoneBook);
    }

    static void inputPhoneBookFromConsole(List<Contact> phoneBook)
    {
        bool is_user_finished = false;
        while(!is_user_finished)
        {
            Console.Write("Введите имя контакта и номер телефона: ");
            string[] read_line_split = Console.ReadLine().Split();

            if(read_line_split.Count() == 2)
            { 
                phoneBook.Add(new Contact(read_line_split[0], read_line_split[1]));
            }
            else 
            { 
                is_user_finished = true; 
            }
        }
    }

    static void outputPhoneBookToConsole(List<Contact> phoneBook)
    {
        foreach(var i in phoneBook)
        {
            Console.WriteLine(i.ToString());
        }
    }
}
