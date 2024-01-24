using System.Text.Json;

namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!\n");

        Console.WriteLine("#1");

        const string path_1 = "1.json";
        string jsonFromFile_1 = File.ReadAllText(path_1);
        Film_Catalog films = JsonSerializer.Deserialize<Film_Catalog>(jsonFromFile_1);

        Director Jhames = new Director("Джеймс Кэмерон", "1954-08-16");
        var Avatar_cast = new List <Cast>
        {
            new Cast{ name = "Сэм Уортингтон", role = "Джейк Салли"},
            new Cast{ name = "Зои Салдана", role = "Нейтири"}
        };
        var Avatar_genres = new List <string>
        {
            "Фантастика", "Фэнтези", "Боевик"
        };
        Ratings Avatar_ratings = new Ratings(7.9, "82%");

        var Terminator_cast = new List <Cast>
        {
            new Cast{ name = "Арнольд Шварценеггер", role = "Терминатор"},
            new Cast{ name = "Майкл Бин", role = "Кайл Риз"}
        };
        var Terminator_genres = new List <string>
        {
            "Фантастика", "Боевик", "Триллер"
        };
        Ratings Terminator_ratings = new Ratings(8.1, "100%");

        var Titanic_cast = new List <Cast>
        {
            new Cast{ name = "Арнольд Шварценеггер", role = "Терминатор"},
            new Cast{ name = "Майкл Бин", role = "Кайл Риз"}
        };
        var Titanic_genres = new List <string>
        {
            "Мелодрама", "История", "Триллер"
        };
        Ratings Titanic_ratings = new Ratings(7.9, "88%");

        Film Avatar = new Film("Аватар", 2009, Jhames, Avatar_cast, Avatar_genres, Avatar_ratings);
        Film Terminator = new Film("Тирменатор", 1984, Jhames, Terminator_cast, Terminator_genres, Titanic_ratings);
        Film Titanic = new Film("Титаник", 1997, Jhames, Titanic_cast, Titanic_genres, Titanic_ratings);
        
        films.Film_catalog.Add(Avatar);
        films.Film_catalog.Add(Terminator);
        films.Film_catalog.Add(Titanic);

        string json_1 = JsonSerializer.Serialize(films);
        File.WriteAllText(path_1, json_1);
        Console.WriteLine("Фильмы добавлены.\n");

        Console.WriteLine("#2");

        const string path_2 = "2.json";
        string jsonFromFile_2 = File.ReadAllText(path_2);
        Company OOO_Roga_i_Koputa = JsonSerializer.Deserialize<Company>(jsonFromFile_2);

        // List <string> skills_program = new List <string> {"ООП", "База данных", "Сетевое администрирование"};
        // Employees programmist = new Employees(1003, "Матигоров Никита", "Программист", skills_program, 250000);
        // OOO_Roga_i_Koputa.employees.Add(programmist);

        // string json_2 = JsonSerializer.Serialize(OOO_Roga_i_Koputa);
        // File.WriteAllText(path_2, json_2);
        // Console.WriteLine("Программист добавлен.\n");

        List <Employees> employees_list = OOO_Roga_i_Koputa.employees;
        List <Positions> positions = new List<Positions>();
        foreach (var person in employees_list)
        {
            bool proverka = false;
            foreach(var prov in positions)
            {
                if (person.position == prov.position)
                {
                    proverka = true;
                    break;
                }
            }
            if (!proverka)
            {
                Positions add = new Positions(person.position, 0);
                positions.Add(add);
            }
        }

        foreach (var i in positions)
        {
            foreach (var k in employees_list)
            {
                if (i.position == k.position)
                {
                    i.count++;
                }
            }
        }

        int sum = 0;
        int count = 0;
        foreach (var i in employees_list)
        {
            sum += i.salary;
            count++;
        }

        const string path_2_1 = "Position_count.json";
        string json_2_1 = JsonSerializer.Serialize(positions);
        File.WriteAllText(path_2_1, json_2_1);
        Console.WriteLine("Средняя зарплата: " + (sum / count));

        // foreach (var i in positions)
        // {
        //     Console.WriteLine(i.position + i.count);
        // }

        // 3 задание //
        
        const string path_3 = "3.json";
        string jsonFromFile_3 = File.ReadAllText(path_3);
        Projects project = JsonSerializer.Deserialize<Projects>(jsonFromFile_3);
        Terminal project_company = new Terminal(project, path_3);

        while (true)
        {
            Console.WriteLine("Выберите команду из предложенного списка:");
            Console.Write("1. Добавить нового сотрудника.\n2. Изменить статус задания.\n3. Сохранить файл.\n0. Выключение программы.\nВведите номер команды: ");
            int id_command = Convert.ToInt32(Console.ReadLine());
            switch(id_command)
            {
                case 1:
                    project_company.Add_person();
                    break;
                case 2:
                    project_company.Change_status();
                    break;
                case 3:
                    project_company.Save_JSON();
                    break;
                case 0:
                    return;
                default:
                Console.WriteLine("Команды под таким номером не существет.");
                break;
            }
        }
    }
}

[System.Serializable] public class Director
{
    public string name { get; set; }
    public string born { get; set; }
    public Director() {}
    public Director(string name_copy, string born_copy)
    {
        this.name = name_copy;
        this.born = born_copy;
    }
}

[System.Serializable] public class Cast
{
    public string name { get; set; }
    public string role { get; set; }
    public Cast() {}
    public Cast(string name_copy, string role_copy)
    {
        this.name = name_copy;
        this.role = role_copy;
    }
}


[System.Serializable] public class Ratings
{
    public double IMDb { get; set; }
    public string Rotten_Tomatoes { get; set; }
    public Ratings() {}
    public Ratings(double IMDb_copy, string Rotten_Tomatoes_copy)
    {
        this.IMDb = IMDb_copy;
        this.Rotten_Tomatoes = Rotten_Tomatoes_copy;
    }
}

[System.Serializable] public class Film
{
    public string title { get; set; }
    public int year { get; set; }
    public Director director { get; set; }
    public List <Cast> cast { get; set; }
    public List <string> genres { get; set; }
    public Ratings ratings { get; set; }
    public Film() {}
    public Film(string title_copy, int year_copy, Director director_copy, List <Cast> cast_copy, List <string> gentes_copy, Ratings ratings_copy)
    {
        this.title = title_copy;
        this.year = year_copy;
        this.director = director_copy;
        this.cast = cast_copy;
        this.genres = gentes_copy;
        this.ratings = ratings_copy;
    }
}

[System.Serializable] public class Film_Catalog
{
    public List <Film> Film_catalog { get; set; }
    public Film_Catalog() {}
    public Film_Catalog(List <Film> Film_catalog_copy)
    {
        this.Film_catalog = Film_catalog_copy;
    }
}

[System.Serializable] public class Employees
{
    public int id { get; set; }
    public string name { get; set; }
    public string position { get; set; }
    public List <string> skills { get; set; }
    public int salary { get; set; }
    public Employees() {}
    public Employees(int id_copy, string name_copy, string position_copy, List <string> skills_copy, int salary_copy) 
    {
        this.id = id_copy;
        this.name = name_copy;
        this.position = position_copy;
        this.skills = skills_copy;
        this.salary = salary_copy;
    }
}

[System.Serializable] public class Location
{
    public string city { get; set; }
    public string address { get; set; }
    public Location() {}
    public Location(string city_copy, string address_copy)
    {
        this.city = city_copy;
        this.address = address_copy;
    }
}

[System.Serializable] public class Company
{
    public string companyName   { get; set; }
    public List <Employees> employees { get; set; }
    public Location location { get; set; }
    public Company() {}
    public Company(string companyName_copy, List <Employees> employees_copy, Location location_copy)
    {
        this.companyName = companyName_copy;
        this.employees = employees_copy;
        this.location = location_copy;
    }
}

[System.Serializable] public class Positions
{
    public string position { get; set; }
    public int count { get; set; }
    public Positions() {}
    public Positions(string position_copy, int count_copy)
    {
        this.position = position_copy;
        this.count = count_copy;
    }
}

// 3 задание // 
[System.Serializable] public class Subtasks
{
    public int id { get; set; }
    public string description { get; set; }
    public string status { get; set; }
    public Subtasks() {}
    public Subtasks(int id_copy, string description_copy, string status_copy)
    {
        this.id = id_copy;
        this.description = description_copy;
        this.status = status_copy;
    }
}

[System.Serializable] public class Tasks
{
    public int id { get; set; }
    public string description { get; set; }
    public string status { get; set; }
    public string assignee { get; set; }
    public List<Subtasks> subtasks { get; set; }
    public Tasks() {}
    public Tasks(int id_copy, string description_copy, string status_copy, string assignee_copy, List<Subtasks> subtasks_copy)
    {
        this.id = id_copy;
        this.description = description_copy;
        this.status = status_copy;
        this.assignee = assignee_copy;
        this.subtasks = subtasks_copy;
    }
}

[System.Serializable] public class Project
{
    public string name { get; set; }
    public string deadline { get; set; }
    public List<Tasks> tasks { get; set; }
    public List<string> team { get; set; }
    public Project() {}
    public Project(string name_copy, string deadline_copy,  List<Tasks> tasks_copy, List<string> team_copy)
    {
        this.name = name_copy;
        this.deadline = deadline_copy;
        this.tasks = tasks_copy;
        this.team = team_copy;
    }
}

[System.Serializable] public class Projects
{
    public Project project { get; set; }
    public Projects() {}
    public Projects(Project project_copy)
    {
        this.project = project_copy;
    }
}

public class Terminal
{
    public Projects project_company;
    public string path;
    public Terminal(Projects project_company_copy, string path_copy)
    {
        this.project_company = project_company_copy;
        this.path = path_copy;
    }
    public void Add_person()
        {
            Console.Write("Введите имя и фамилию: ");
            string name = Console.ReadLine();
            project_company.project.team.Add(name);
            Console.WriteLine("Сотрудник добавлен.");
            return;
        }

        public void Change_status()
        {
            bool id_find = false;
            Console.Write("Введите id задания: ");
            int id_task = Convert.ToInt32(Console.ReadLine());
            foreach (var pro in project_company.project.tasks)
            {
                if (pro.id == id_task)
                {
                    Console.Write("Введите статус задания:");
                    pro.status = Console.ReadLine();
                    Console.WriteLine("Статус изменён.");
                    id_find = true;
                }
            }
            if (!id_find)
            {
                Console.WriteLine("Такого id не существует.");
            }
            return;
        }
        public void Save_JSON()
        {
            Projects project = project_company;
            string json_3 = JsonSerializer.Serialize(project);
            File.WriteAllText(path, json_3);
        }
}