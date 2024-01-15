// Практика С

// задание 1
string json = @"{
    'title': 'Назад в будущее',
    'year': 1985,
    'director': {
        'name': 'Роберт Земекис',
        'born': '1952-05-14'
    },
    'cast': [
        {
            'name': 'Майкл Дж. Фокс',
            'role': 'Марти МакФлай'
        },
        {
            'name': 'Кристофер Ллойд',
            'role': 'Доктор Эмметт Браун'
        }
    ],
    'genres': ['Приключения', 'Комедия', 'Научная фантастика'],
    'ratings': {
        'IMDb': 8.5,
        'Rotten Tomatoes': '96%'
    }
}";

List<Movie> movies = JsonConvert.DeserializeObject<List<Movie>>(json);

// добавляем три фильма из Кинопоиска
movies.Add(new Movie { Title = "Джон Уик 4", Year = 2023, Director = new Director { Name = "Чад Стахелски" } });
movies.Add(new Movie { Title = "Вонка", Year = 2023 });
movies.Add(new Movie { Title = "Заветное желание", Year = 2023 });

string newJson = JsonConvert.SerializeObject(movies);

// сохраняем результат в файл
File.WriteAllText("movies.json", newJson);

// задание 2
string json = @"{
    'project': {
        'name': 'Разработка веб-сайта',
        'deadline': '2023-12-31',
        'tasks': [
            {
                'id': 101,
                'description': 'Дизайн главной страницы',
                'status': 'Выполнено',
                'assignee': 'Ирина Васильева',
                'subtasks': [
                    {'id': 1011, 'description': 'Выбор цветовой палитры', 'status': 'Выполнено'},
                    {'id': 1012, 'description': 'Разработка макета', 'status': 'В работе'}
                ]
            },
            {
                'id': 102,
                'description': 'Разработка клиентской части',
                'status': 'В работе',
                'assignee': 'Дмитрий Петров'
            }
        ],
        'team': ['Ирина Васильева', 'Дмитрий Петров', 'Елена Соколова']
    }
}";

Project project = JsonConvert.DeserializeObject<Project>(json);

// добавляем программиста в команду проекта
TeamMember programmer = new TeamMember { Name = "Программист", Salary = 250000 };
project.Team.Add(programmer);

string newJson = JsonConvert.SerializeObject(project);

// сохраняем результат в файл
File.WriteAllText("project.json", newJson);

// задание 3
// список сотрудников с их специальностями
List<Employee> employees = new List<Employee>
{
    new Employee { Name = "Ирина Васильева", Specialty = "Дизайнер" },
    new Employee { Name = "Дмитрий Петров", Specialty = "Разработчик" },
   
};

// считаем количество сотрудников по специальностям
var specialtyCounts = employees
    .GroupBy(e => e.Specialty)
    .ToDictionary(g => g.Key, g => g.Count());

// сериализуем результат в JSON
string json = JsonConvert.SerializeObject(specialtyCounts);

// записываем JSON в файл
File.WriteAllText("specialtyCounts.json", json);
// список сотрудников с их зарплатами
List<Employee> employees = new List<Employee>
{
    new Employee { Name = "Ирина Васильева", Salary = 100000 },
    new Employee { Name = "Дмитрий Петров", Salary = 120000 },
    
};

// считаем среднюю зарплату
double averageSalary = employees.Average(e => e.Salary);

Console.WriteLine($"Средняя зарплата в компании: {averageSalary}");
// изменение статуса сотрудника
void ChangeEmployeeStatus(Employee employee, string newStatus)
{
    employee.Status = newStatus;
}

// добавление нового сотрудника
void AddEmployee(List<Employee> employees, Employee newEmployee)
{
    employees.Add(newEmployee);
}