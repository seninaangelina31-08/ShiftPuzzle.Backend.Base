public class AccountManager : IAccountManager
{
    private readonly AccountContext _context;

    public AccountManager(AccountContext context)
    {
        _context = context;
    }

    public void RegisterAccount(User account)
    {
        // Заглушка
    }

    public User GetAccount(string accountName)
    {
        // Заглушка
        return null;
    }

    public List<User> GetAccounts()
    {
        // Заглушка
        return null;
    }

    public bool VerifyAccount(User account)
    {
        // Заглушка
        return false;
    }
}
