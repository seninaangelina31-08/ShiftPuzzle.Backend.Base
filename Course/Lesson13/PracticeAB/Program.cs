namespace PracticeAB;
using System.Collections.Generic; // библиотека для работы с List и Dictionary

using System.Text.Json; 
//*ЧастьА:* 
//1. Выведи почту и ID пользователя Иванов Иван
//2. Выводи список товаров которая купила Анна Петрова и сделай скидку 10%
//3. Выведи средний балл Сергея Сидорова
//*ЧастьБ:*
//4. Добавь в список покупок Анны салфетки для мониторв за 1550р и сделай к итогу скидку 2%. и Запиши  в файл.
//5. Добавь книгу любую Пушкина и запиши в файл


[System.Serializable] public class Anna
{
    // поля класса
    public string orderId { get; set; }
    public string customerName { get; set; }
    public int totalPrice { get; set; }
    public List<string> items { get; set; }

    public Anna() { } // Пустой конструктор для десериализации

   
}
[System.Serializable] public class Product
{
    // поля класса
    public int id { get; set; }
    public string name { get; set; }
    public string email { get; set; }
    public bool isVerified { get; set; }

    public Product() { } // Пустой конструктор для десериализации

   
}
[System.Serializable] public class Library
{
    public string libraryName { get; set; }
    public List<Book> books { get; set; }

    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public int year { get; set; }
    }
}
class Program
{
    static void Main(string[] args)
    {

       

        const string path = "1.json";
        const string path2 = "2.json";
        const string path3 = "6.json";
        const string path5 = "5.json";

        // Десериализация из JSON
        string js = File.ReadAllText(path);
        Product info = JsonSerializer.Deserialize<Product>(js);

        string js2 = File.ReadAllText(path2);
        Anna inf2 = JsonSerializer.Deserialize<Anna>(js2);

        string js3 = File.ReadAllText(path3);
        Anna inf3 = JsonSerializer.Deserialize<Anna>(js3);

        string js4 = File.ReadAllText(path5);
        Library inf4 = JsonSerializer.Deserialize<Library>(js4);

       

        if (info != null)
        {
            // вывод полей объекта
            Console.WriteLine($"Name: {info.name}\nEmail: {info.email}");
        
           
        }
        if (inf2!=null)
        {
            Console.WriteLine("Список продуктов:");
            foreach (string prd in inf2.items)
            {
                Console.WriteLine(prd);
            }
            Console.WriteLine($"Цена покупки со скидкой:{inf2.totalPrice*0.9}");
        }
        // Добавляем значение "книга" в массив "items"
        inf3.items.Add("салфетки для монитора");

        
        inf3.totalPrice = 7150;
        Console.WriteLine("Список продуктов обновленный:");
        // Сериализуем обновленный объект в JSON
        string updatedJson = JsonSerializer.Serialize(inf3);
        foreach (string p in inf3.items)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine($"Цена покупки со скидкой: {inf3.totalPrice * 0.98}");


        Library.Book newlib = new  Library.Book { title = "Руслан и Людмила", author = "А. С.Пушкин", year= 1820 };

        inf4.books.Add(newlib);

        string lbsb = JsonSerializer.Serialize(inf4);

        
    }
}
