
public class AccountManager : IAccountManager
{
    private readonly AccountContext _context;

    public AccountManager(AccountContext context)
    {
        _context = context;
    }

    public User? GetAccount(string accountName)
    {
        return _context.Users.FirstOrDefault(u => u.Name == accountName);
    }

    public List<User> GetAccounts()
    {
        return _context.Users.ToList();
    }

    public void RegisterAccount(User account)
    {
        _context.Users.Add(account);
        _context.SaveChanges();
    }

    public bool VerifyAccount(User account)
    {
        if (_context.Users.Any(u => u.Name == account.Name && u.Password == account.Password))
        {
            var CurrentUser = account;
            Console.WriteLine("Account verified.");
            return true;
        }
        else
        {
            Console.WriteLine("Account not verified.");
            return false;
        }
    }
}
