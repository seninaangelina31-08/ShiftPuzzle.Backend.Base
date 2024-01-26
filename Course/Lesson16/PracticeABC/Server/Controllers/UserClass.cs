public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public bool IsAuthorized { get; set; }

    public User(){}
    public User(string Login, string Password)
    {
        this.Login = Login;
        this.Password = Password;
        this.IsAuthorized = false;
    }
}