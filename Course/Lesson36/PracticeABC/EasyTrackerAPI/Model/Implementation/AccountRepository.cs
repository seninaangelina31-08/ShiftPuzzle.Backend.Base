
public class AccountRepository : IAccountRepository
{
    private readonly AccountContext _context;
    public AccountRepository(AccountContext context)
    {
        _context = context;
    }


    public void RegisterAccount(User account)
    {
        _context.Users.Add(account);
        _context.SaveChanges();
    }

    public User GetAccount(string accountName)
    {
        return _context.Users.FirstOrDefault(u => u.Name == accountName);
    }

    public List<User> GetAccounts()
    {
        return _context.Users.ToList();
    }

    public bool VerifyAccount(string email, string password)
    {
        if(_context.Users.Any(u => u.Email== email && u.Password == password))
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
