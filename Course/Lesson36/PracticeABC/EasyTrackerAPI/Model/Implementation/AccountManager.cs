public class AccountManager : IAccountManager 
{
    private readonly AccountContext _context;

    public AccountManager(AccountContext context)
    {
        _context = context;
    }

    public void RegisterAccount(User account)
    {
        if ((account.Name != null) && (account.Password != null))
        {
            _context.Users.Add(account);
            _context.SaveChanges();
            Console.WriteLine("Account registered");
        }
        else
        {
            Console.WriteLine("Account not registered");
        }
    }

    public User GetAccount(string accountName)
    {
        return _context.Users.Where(u => u.Name == accountName).FirstOrDefault();
    }

    public List<User> GetAccounts()
    {
        return _context.Users.ToList();
    }

    public bool VerifyAccount(User account)
    {
        if(_context.Users.Any(u => u.Name == account.Name && u.Password == account.Password))
        {
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