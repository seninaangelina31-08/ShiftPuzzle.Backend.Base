//3. Создать класс пользователя:
//    - ИД
//    - ИМЯ
//    - ПОЧТА
//    - ПАРОЛЬ
//    - ВСЕ ПРИКРЕПЛЕННЫЕ ЗАДАЧИ

public class User
{ 

    public User(string name)
    {
        Name = name; 
    }

    public int ID { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }    
}