using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Unicode;
using System.Text.Encodings.Web;

namespace PracticeC;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var options1 = new JsonSerializerOptions {Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic), WriteIndented = true};
        // Console.WriteLine($"Сейчас будет заполнение нового фильма\nВведите название фильма");
        // string filmTitle = Console.ReadLine();
        // Console.WriteLine($"Введите год выпуска фильма");
        // int filmYear = Convert.ToInt16(Console.ReadLine());


        // Console.WriteLine($"Введите имя и фамилию режиссёра фильма");
        // string filmDirectorName = Console.ReadLine();
        // Console.WriteLine($"Введите дату рождения режиссёра в формате гггг-мм-дд");
        // string filmDirectorBorn = Console.ReadLine();
        // var director = new Dictionary<string, string> {{filmDirectorName, filmDirectorBorn}};


        // int castAnswer = -1;
        // List<Dictionary<string, string>> cast = new();

        // while (castAnswer != 0)
        // {
        //     Console.WriteLine($"Добавьте актера");
        //     Console.WriteLine($"Введите ФИО актёра");
        //     string castName = Console.ReadLine();

        //     Console.WriteLine($"Введите, кого играл этот актёр");
        //     string castRole = Console.ReadLine();

        //     var actor = new Dictionary<string, string> {{castName, castRole}};
        //     cast.Add(actor);

        //     Console.WriteLine($"1 - Добавить ещё актёра\n0 - выйти из меню добавления актёра");
        //     castAnswer = Convert.ToInt16(Console.ReadLine());
        // }


        // int genresAnswer = -1;
        // List<string> genres = new();
        // while (genresAnswer != 0)
        // {
        //     Console.WriteLine($"Добавьте жанр");
        //     genres.Add(Console.ReadLine());

        //     Console.WriteLine($"1 - Добавить ещё жанр\n0 - выйти из меню добавления жанра");
        //     genresAnswer = Convert.ToInt16(Console.ReadLine());
        // }


        // int ratingsAnswer = -1;
        // var ratings = new Dictionary<string, string> {};
        // while (ratingsAnswer != 0)
        // {
        //     Console.WriteLine($"Добавьте критика");
        //     string critic = Console.ReadLine();
        //     Console.WriteLine($"Введите оценку этого критика");
        //     ratings.Add(critic, Console.ReadLine());

        //     Console.WriteLine($"1 - Добавить ещё критика\n0 - выйти из меню добавления критика");
        //     ratingsAnswer = Convert.ToInt16(Console.ReadLine());
        // }



        // Film film = new(filmTitle, filmYear, director, cast, genres, ratings);
        // string filmJson = JsonSerializer.Serialize(film);
        // Console.WriteLine("Введите название файла");
        // string filmPath = Console.ReadLine();
        // Console.WriteLine(filmJson);
        // File.WriteAllText(filmPath, filmJson);





        // string companyPath = "2.json";
        // string companyInfo = File.ReadAllText(companyPath);
        // Company company = JsonSerializer.Deserialize<Company>(companyInfo);
        
        // int salary = 0;
        // int counter = 0;
        // foreach (var employee in company.employees)
        // {
        //     salary += Convert.ToInt16(employee["salary"]);
        //     counter++;
        // }

        Console.WriteLine($"Средняя зарплата = {520000 / 3}");
    }

    [System.Serializable] public class Film
    {
        public string Title { get; set; }
        public int Year{ get; set; }
        public Dictionary<string, string> Director{ get; set; }
        public List<Dictionary<string, string>> Cast{ get; set; }
        public List<string> Genres{ get; set; }
        public Dictionary<string, string> Ratings{ get; set; }

        public Film(string titleObj,
                    int yearObj,
                    Dictionary<string, string> directorObj,
                    List<Dictionary<string, string>> castObj,
                    List<string> genresObj,
                    Dictionary<string, string> ratingsObj)
        {
            this.Title = titleObj;
            this.Year = yearObj;
            this.Director = directorObj;
            this.Cast = castObj;
            this.Genres = genresObj;
            this.Ratings = ratingsObj;
        }
    }


    [System.Serializable] public class Company
    {
        public string companyName { get; set; }
        public List<Dictionary<string, string>> employees{ get; set; }
        public Dictionary<string, string> location { get; set; }

        public Company() { }

        public Company(string companyNameObj,
                       List<Dictionary<string, string>> employeesObj,
                       Dictionary<string, string> locationObj)
        {
            this.companyName = companyNameObj;
            this.employees = employeesObj;
            this.location = locationObj;
        }
    }
}
