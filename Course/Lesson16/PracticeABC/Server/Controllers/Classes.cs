namespace Controllers;

// Класс продукта
public class Product
{
    // Название продукта
    public string Name { get; set; }
    // Цена продукта
    public double Price { get; set; }
    // Сколько в наличии
    public int Stock { get; set; }

    public Product(string name, double price, int stock)
    {
        Name = name;
        Price = price;
        Stock = stock;
    }
}

// Класс для передачи данных для обновления названия продукта
public class UpdateNameData
{
    // Текущее название продукта
    public string CurrentName { get; set; }
    // Новое название продукта
    public string NewName { get; set; }

    public UpdateNameData(string currentName, string newName)
    {
        CurrentName = currentName;
        NewName = newName;
    }
}

// Класс для передачи данных дял удаления продукта
public class DeleteNameData
{
    // Название удаляемого продукта
    public string Name { get; set; }

    public DeleteNameData(string name)
    {
        Name = name;
    }
}

// Клас пользователя
public class User
{
    // Логин
    public string Login { get; set; }
    // Пароль
    public string Password { get; set; }
    // Авторизирован ли пользователь
    public bool IsAuthorized { get; set; }

    public User(){}
    public User(string login, string password, bool isAuthorized)
    {
        this.Login = login;
        this.Password = password;
        this.IsAuthorized = isAuthorized;
    }
}