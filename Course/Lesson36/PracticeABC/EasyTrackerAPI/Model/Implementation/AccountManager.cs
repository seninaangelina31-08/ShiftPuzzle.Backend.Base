public class AccountManager : IAccountManager
{
    private AccountContext _context;

    public AccountManager(AccountContext context)
    {
        _context = context;
    }

    public void RegisterAccount(User account)
    {
        Console.WriteLine("Зарегисрировано");
    }

    public User GetAccount(string accountName)
    {
        User user = new User("Ilya");
        return user;
    }

    public List<User> GetAccounts()
    {
        List<User> lst = new List<User>{};
        return lst;
    }

    public bool VerifyAccount(User account)
    {
        return true;
    }
}