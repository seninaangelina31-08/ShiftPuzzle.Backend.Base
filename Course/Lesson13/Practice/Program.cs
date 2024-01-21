using System.Text.Json;

namespace Practice;

class Program
{
    static void Main(string[] args)
    {
        const string path_1 = @"C:\Work\Lesson\ShiftPuzzle.Backend.Base\Course\Lesson13\PracticeAB\1.json";
        string jsonFromFile_1 = File.ReadAllText(path_1);
        User person = JsonSerializer.Deserialize<User>(jsonFromFile_1);
        
        if (person != null){
            Console.WriteLine("#1");
            Console.WriteLine($"ID: {person.id}\nEmail: {person.email}");
        }

        const string path_2 = @"C:\Work\Lesson\ShiftPuzzle.Backend.Base\Course\Lesson13\PracticeAB\2.json";
        string jsonFromFile_2 = File.ReadAllText(path_2);
        Chek person_chek = JsonSerializer.Deserialize<Chek>(jsonFromFile_2);

        if (person_chek != null){
            Console.WriteLine("#2");
            Console.WriteLine("Список товаров:");
            foreach (string str in person_chek.items)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine($"Итоговая цена с учётом скидки: {person_chek.totalPrice - (person_chek.totalPrice / 100 * 10)}\n");
        }

        const string path_4 = @"C:\Work\Lesson\ShiftPuzzle.Backend.Base\Course\Lesson13\PracticeAB\4.json";
        string jsonFromFile_4 = File.ReadAllText(path_4);
        Chek person_edit = JsonSerializer.Deserialize<Chek>(jsonFromFile_4);

        Console.WriteLine("#4");
        const string new_item = "Салфетки для монитора";
        person_edit.items.Add(new_item);
        person_edit.totalPrice += 1550;
        person_edit.totalPrice -= person_edit.totalPrice * 1000 / 100 * 2 / 1000;
        string json_4 = JsonSerializer.Serialize(person_edit);
        File.WriteAllText(path_4, json_4);
        Console.WriteLine("Товар добавлен.\n");

        const string path_5 = @"C:\Work\Lesson\ShiftPuzzle.Backend.Base\Course\Lesson13\PracticeAB\5.json";
        string jsonFromFile_5 = File.ReadAllText(path_5);
        Library library_5 = JsonSerializer.Deserialize<Library>(jsonFromFile_5);


        Console.WriteLine("#5");
        Book Pushkin = new Book("Евгений Онегин", "Александр Пушкин", 1833);
        library_5.books.Add(Pushkin);
        string json_5 = JsonSerializer.Serialize(library_5);
        File.WriteAllText(path_5, json_5);
        Console.WriteLine("Книга добавлена.\n");

    }
}

[System.Serializable] public class User
{
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public bool isVerifired { get; set; }
    public User() {}
    public User(int idc, string namec, string emailc, bool isVerifiredc)
    {
        this.id = idc;
        this.name = namec;
        this.email = emailc;
        this.isVerifired = isVerifiredc;
    }
}

[System.Serializable] public class Chek
{
    public string orderId { get; set; }
    public string customerName { get; set; }
    public int totalPrice { get; set; }
    public List<string> items { get; set; }
    public Chek() {}
    public Chek(string idc, string namec, int price, List<string> itemsc)
    {
        this.orderId = idc;
        this.customerName = namec;
        this.totalPrice = price;
        this.items = itemsc;
    }
}

[System.Serializable] public class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public int year { get; set; }
    public Book() {}
    public Book(string titlec, string authorc, int yearc)
    {
        this.title = titlec;
        this.author = authorc;
        this.year = yearc;
    }
}

[System.Serializable] public class Library
{
    public string libraryName { get; set; }
    public List <Book> books { get; set; }
    public Library() {}
    public Library(string libraryNamec, List <Book> booksc)
    {
        this.libraryName = libraryNamec;
        this.books = booksc;
    }
}