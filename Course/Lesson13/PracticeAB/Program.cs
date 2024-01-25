const string path_1 = @"C:\ShiftPuzzle.Backend.Base\Course\Lesson13\PracticeAB\1.json";
string jsonFromFile_1 = File.ReadAllText(path_1);
User person = jsonSerializer.Deserialize<User>(jsonFromFile_1);

if (person != null)
{
    Console.WriteLine("#1");
    Console.WriteLine($"Id: {person.id} Email: {person.email}");
}

const string path_2 = @"C:\ShiftPuzzle.Backend.Base\Course\Lesson13\PracticeAB\2.json";
string jsonFromFile_2 = File.ReadAllText(path_2);
User person_info = jsonSerializer.Deserialize<Info>(jsonFromFile_2);

if (person_info != null)
{
    Console.WriteLine("#2");
    Console.WriteLine("Список товаров:");

    foreach (string str ijn person_info.items)
    {
        Console.WriteLine(str);
    }
    Console.WriteLine($"Итоговая цена с учётом скидки: {person_info.totalPrice - (person_info.totalPrice / 100 * 10)}");

}

const string path_4 = @"C:\ShiftPuzzle.Backend.Base\Course\Lesson13\PracticeAB\4.json";
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

const string path_5 = @"C:\ShiftPuzzle.Backend.Base\Course\Lesson13\PracticeAB\5.json";
string jsonFromFile_5 = File.ReadAllText(path_5);
Library library_5 = JsonSerializer.Deserialize<Library>(jsonFromFile_5);

Console.WriteLine("#5");
Book Pushkin = new Book("Евгений Онегин", "Александр Пушкин", 1833);
library_5.books.Add(Pushkin);
string json_5 = JsonSerializer.Serialize(library_5);
File.WriteAllText(path_5, json_5);
Console.WriteLine("Книга добавлена.\n")


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