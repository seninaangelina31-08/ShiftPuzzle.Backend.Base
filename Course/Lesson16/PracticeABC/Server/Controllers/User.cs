namespace PracticeA;


public class User 
{
    public string Name { get; set; }
    public string Loggin { get; set; }
    public string Password { get; set; }
    public bool IsAuthorized { get; set; }

    public User() {}

    public User(string name, string loggin, string password)
    {
        this.Name = name;
        this.Loggin = loggin;
        this.Password = password;
        this.IsAuthorized = false;
    }
}