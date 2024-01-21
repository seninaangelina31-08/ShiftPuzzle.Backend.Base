namespace PracticeC;
using System;
using System.Text.Json;

public class FilmList
{
    public List<Film> film_list { get; set; }

    public FilmList(){}
    public FilmList(List<Film> film_list)
    {
        this.film_list = film_list;
    }
}
[System.Serializable] public class Film
{
    public string title { get; set; }
    public int year { get; set; }
    public Director director { get; set; }
    public List<Actor> cast { get; set; }
    public List<string> genres { get; set; }
    public Rating ratings { get; set; }

    public Film(){}
    public Film(string title, int year, Director director, List<Actor> cast, List<string> genres, Rating ratings)
    {
        this.title = title;
        this.year = year;
        this.director = director;
        this.cast = cast;
        this.genres = genres;
        this.ratings = ratings;
    }

}
[System.Serializable] public class Director
{
    public string name { get; set; }
    public string born { get; set; }

    public Director(){}
    public Director(string name, string born)
    {
        this.name = name;
        this.born = born;
    }
}
[System.Serializable] public class Actor
{
    public string name { get; set; }
    public string role { get; set; }
    
    public Actor(){}
    public Actor(string name, string role)
    {
        this.name = name;
        this.role = role;
    }
}

[System.Serializable] public class Rating
{
    public double IMDb { get; set; }
    public string RottenTomatoes {get; set; }

    public Rating(){}
    public Rating(double IMDb, string RottenTomatoes)
    {
        this.IMDb = IMDb;
        this.RottenTomatoes = RottenTomatoes;
    }

}


[System.Serializable] public class Company
{
    public string companyName { get; set; }
    public List<Employee> employees { get; set; }
    public Company(){}
    public Company(string companyName, List<Employee> employees)
    {
        this.companyName = companyName;
        this.employees = employees;

    }
}
[System.Serializable] public class Employee
{
    public int id { get; set; }
    public string name { get; set; }
    public string position { get; set;}
    public List<string> skills {get; set; }
    public int salary { get; set; }

    public Employee(){}
    public Employee(int id, string name, string position, List<string> skills, int salary)
    {
        this.id = id;
        this.name = name;
        this.position = position;
        this.skills = skills;
        this.salary = salary;
    }
}
[System.Serializable] public class Count
{
    public Dictionary<string, int> dict { get; set; }
    
    public Count(){}
    public Count(Dictionary<string, int> dict)
    {
        this.dict = dict;
    }
}
class Program
{

    static Company Menu()
    {   
        Company company_1 = new Company("", []);
        Console.Write("Введите название компании: ");
        company_1.companyName = Console.ReadLine();
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int sum = 0;
        int c = 0;        
        while (true)
        {
            Console.WriteLine("1.Добавить работника\n2.Выход");
            Console.Write("Выберите вариант: ");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    Console.Write("Введите id работника: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите имя работника: ");
                    string name = Console.ReadLine();
                    Console.Write("Введите должность работника: ");
                    string position = Console.ReadLine();
                    dict[position] = 0;
                    dict[position] += 1;              
                    Console.WriteLine("Введите навыки работника через enter, макс = 3");
                    List<string> skills = [];
                    for (int i = 0; i < 3; i++)
                    {
                        skills.Add(Console.ReadLine());   
                    }
                    Console.Write("Введите з/п: ");
                    int salary = Convert.ToInt32(Console.ReadLine());
                    sum += salary;
                    c++;
                    Employee employee = new Employee(id, name, position, skills, salary);
                    company_1.employees.Add(employee);


                    Console.WriteLine("Работник успешно добавлен");
                    break;
                case 2:
                    string dictionary = JsonSerializer.Serialize<Count>(new Count(dict));
                    File.WriteAllText("2_count.json", dictionary);
                    Console.WriteLine($"Средняя з/п в этой компании: {sum / c}");
                    return company_1;
            }
        }
    }
    static void Main(string[] args)
    {
        //Task1
        string path = "1.json";
        string read_json = File.ReadAllText(path);

        Film film_1 = JsonSerializer.Deserialize<Film>(read_json);
        FilmList lst = new FilmList([film_1]);
        
        Film film_2 = new Film("Джентельмены", 2019, new Director("Гай Ричи", "1968-09-10"),
         [new Actor("Мэтью Макконахи", "Майкл Пирсон"), new Actor("Чарли Ханнэм", "Рэймонд Смит")],
         ["Криминал", "Комедия", "Боевик"], new Rating(7.8, "80%"));
         lst.film_list.Add(film_2);

        Film film_3 = new Film("Мстители: Финал", 2019, new Director("Братья Руссо", "1970-03-03;1971-07-08"),
         [new Actor("Роберт Дауни-младший", "Тони Старк"), new Actor("Крис Эванс", "Стив Роджерс"),
         new Actor("Крис Хемсворт", "Тор")],
         ["Боевик", "Фантанстика", "Приключения", "Супергероика"], new Rating(8.5, "95%"));
         lst.film_list.Add(film_3);
        
        Film film_4 = new Film("Звездные войны: Пробуждение силы", 2015,
         new Director("Дж.Дж.Абрамс", "1966-06-27"),
         [new Actor("Харрисон Форд", "Хан Соло"), new Actor("Джон Бойега", "Финн")],
         ["Эпическая космическая опера"], new Rating(7.8, "85%"));
         lst.film_list.Add(film_4);

        string write_json = JsonSerializer.Serialize(lst);
        File.WriteAllText("1_solve.json", write_json);


        //Task2
        path = "2.json";
        read_json = File.ReadAllText(path);
        Company company = JsonSerializer.Deserialize<Company>(read_json);
        company.employees.Add(new Employee(666, "Алеша Анонимус", "Программист", 
         ["Взломал Пентагон", "Вечно хочет спать", "Заменит Сисадмина"], 250000));
        write_json = JsonSerializer.Serialize(company);
        int sum_zp = 0;
        int c = 0;
        foreach (var el in company.employees)
        {
            sum_zp += el.salary;
            c++;
        }
        Console.WriteLine($"Средняя зарплата в компании: {sum_zp / c}");
        File.WriteAllText("2_1_solve.json", write_json);
        Company new_company = Menu();

    }
}
