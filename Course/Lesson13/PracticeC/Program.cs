namespace PracticeC;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
class Program
{
    static void Main(string[] args)
    {

        // PracticeC1

        var options1 = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };

        Director DirectorLeon = new Director("Люк Бессон", "1959-03-18");
        Actor JeanReno = new Actor("Жан Рено", "Леон");
        Actor NatalyPortman = new Actor("Натали Портман", "Матильда");
        List<Actor> CastLeon = new List<Actor> { JeanReno, NatalyPortman };
        List<string> GenresLeon = new List<string> { "Боевик", "Триллер" };
        Ratings RatingsLeon = new Ratings(8.5, "74%");
        Film Leon = new Film("Леон", 1994, DirectorLeon, CastLeon, GenresLeon, RatingsLeon);

        Director DirectorFightClub = new Director("Девид Финчер", "1962-08-28");
        Actor BradleyPitt = new Actor("Брэд Пит", "Тайлер Дерден");
        Actor EdwardNorton = new Actor("Эдвард Нортон", "Рассказчик");
        List<Actor> CastFightClub = new List<Actor> { BradleyPitt, EdwardNorton };
        List<string> GenresFightClub = new List<string> { "Боевик", "Драма", "Триллер" };
        Ratings RatingsFightClub = new Ratings(8.8, "79%");
        Film FightClub = new Film("Бойцовский клуб", 1999, DirectorFightClub, CastFightClub, GenresFightClub, RatingsFightClub);

        Director DirectorHachi = new Director("Ларс Халльстрём", "1946-06-02");
        Actor RichardGere = new Actor("Ричард Гир", "Паркер Уилсон");
        Actor JoanAllen = new Actor("Джоан Аллен", "Кейт Уилсон");
        List<Actor> CastHachi = new List<Actor> { JeanReno, NatalyPortman };
        List<string> GenresHachi = new List<string> { "Драма", "Семейный" };
        Ratings RatingsHachi = new Ratings(8.4, "64%");
        Film Hachi = new Film("Хатико: Самый верный друг", 2008, DirectorHachi, CastHachi, GenresHachi, RatingsHachi);

        const string path1 = "1.json";
        string JsonFromFile1 = File.ReadAllText(path1);
        Films FilmsDes = JsonSerializer.Deserialize<Films>(JsonFromFile1);

        FilmsDes.films.Add(Leon);
        FilmsDes.films.Add(FightClub);
        FilmsDes.films.Add(Hachi);

        string json1 = JsonSerializer.Serialize(FilmsDes, options1);
        // File.WriteAllText(path1, json1);

        // PracticeC2



        // PracticeC2,1

        List<string> skills = new List<string> { "Знает frontend", "Знает backend", "Scrum-мастер" };
        Employee programmer1 = new Employee(1003, "Константин Пельменьев", "Senior программист", skills, 250000);

        const string path2 = "2.json";
        string JsonFromFile2 = File.ReadAllText(path2);
        Company CompanyDec = JsonSerializer.Deserialize<Company>(JsonFromFile2);

        CountAllEmployees();
        // CompanyDec.employees.Add(programmer1);

        // string json2 = JsonSerializer.Serialize(CompanyDec, options1);
        // File.WriteAllText(path2, json2);




        // PracticeC2,2

        // Функция для подсчета и записи сотрудников
        void CountAllEmployees()
        {
            const string pathEmps = "countEmployees.json";
            string JsonFromFileEmps = File.ReadAllText(pathEmps);
            CountEmployees countEmployees = JsonSerializer.Deserialize<CountEmployees>(JsonFromFileEmps);

            int countProgrammers = 0;
            int countDirectors = 0;
            int countAccountants = 0;

            foreach (Employee NamePar in CompanyDec.employees) {
                if ((NamePar.position == "Junior программист") || (NamePar.position == "Middle программист") || (NamePar.position == "Senior программист") || (NamePar.position == "Тимлид")) {
                    countProgrammers++;
                }
                else if ((NamePar.position == "Главный бухгалтер") || (NamePar.position == "Бухгалтер")) {
                    countAccountants++;
                }
                else if (NamePar.position == "Директор") {
                    countDirectors++;
                }
            }

            countEmployees.directors = countDirectors;
            countEmployees.accountants = countAccountants;
            countEmployees.programmers = countProgrammers;

            string jsonEmps = JsonSerializer.Serialize(countEmployees, options1);
            File.WriteAllText(pathEmps, jsonEmps);
        }



        Employee programmer2 = new Employee(1004, "Маргарита Кобякова", "Junior программист", skills, 140000);
        Employee programmer3 = new Employee(1005, "Антон Татыржа", "Тимлид", skills, 400000);
        List<string> skillsAcc = new List<string> { "Умеет быстро считать", "Грамотный аналитик" };
        Employee accountant2 = new Employee(1006, "Дима Масленников", "Бухгалтер", skillsAcc, 80000);

        // CompanyDec.employees.Add(programmer2);
        // CompanyDec.employees.Add(programmer3);
        // CompanyDec.employees.Add(accountant2);

        CountAllEmployees();
        string json2_2 = JsonSerializer.Serialize(CompanyDec, options1);
        File.WriteAllText(path2, json2_2);


        // PracticeC2.3

        int SumSalary = 0;
        int CountEmployees = 0;

        foreach (Employee NamePar in CompanyDec.employees) {
            SumSalary += NamePar.salary;
            CountEmployees++;
        }

        Console.WriteLine("\nЗадание 2.3");
        Console.WriteLine("Средняя запрлата");
        Console.WriteLine(SumSalary/CountEmployees);


        // PracticeC3

        const string path3 = "3.json";
        string JsonFromFile3 = File.ReadAllText(path3);
        ProjectObj WebSite = JsonSerializer.Deserialize<ProjectObj>(JsonFromFile3);


        // Добавление нового работника 
        bool AddNewEmployee(string NameEmp)
        {
            foreach(string name in WebSite.project.team)
            {
                if (NameEmp == name)
                {
                    Console.WriteLine($"Работник {NameEmp} уже есть в команде");
                    return false;
                }
            }
            WebSite.project.team.Add(NameEmp);
            string json3_2 = JsonSerializer.Serialize(WebSite, options1);
            File.WriteAllText(path3, json3_2);
            Console.WriteLine($"Работник {NameEmp} добавлен в команду");
            return true;
        }

        // Изменение статуса задачи
        bool ChangeStatus(int idTask, string NewStatus)
        {
            int lenID = idTask.ToString().Length;
            if (lenID == 3)
            {
                foreach(Task task in WebSite.project.tasks)
                {
                    if (idTask == task.id)
                    {
                        if (task.status == NewStatus)
                        {
                            Console.WriteLine("Данный статус уже приписан к задаче");
                            return true;
                        }
                        else if (task.status != NewStatus)
                        {
                            task.status = NewStatus;
                            Console.WriteLine("Статус задачи изменен");
                            string json3_2 = JsonSerializer.Serialize(WebSite, options1);
                            File.WriteAllText(path3, json3_2);
                            return true;
                        }
                    }
                }
            }
            else if (lenID == 4)
            {
               foreach(Task task in WebSite.project.tasks)
                {
                    foreach (Subtask subtask in task.subtasks)
                    {
                        if (idTask == subtask.id)
                        {
                            if (subtask.status == NewStatus)
                            {
                                Console.WriteLine("Данный статус уже приписан к подзадаче");
                                return true;
                            }
                            else if (subtask.status != NewStatus)
                            {
                                subtask.status = NewStatus;
                                Console.WriteLine("Статус подзадачи изменен");
                                string json3_2 = JsonSerializer.Serialize(WebSite, options1);
                                File.WriteAllText(path3, json3_2);
                                return true;
                            }
                        }
                    }
                } 
            }
            Console.WriteLine("Такого Id не существует");
            return false;
        }

        Console.WriteLine("\nЗадание 3");

        ChangeStatus(1012, "В работе");
        ChangeStatus(102, "В работе");

        AddNewEmployee("Николай Калинов");
        AddNewEmployee("Владимир Галушкин");
    }
}
