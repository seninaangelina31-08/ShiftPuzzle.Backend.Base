public class AccountManager : IAccountManager
{
    private readonly AccountContext _context;

    public AccountManager(AccountContext context)
    {
        _context = context;
    }

    public bool VerifyAccount(User account)
    {
        if(_context.Users.Any(u => u.Name == account.Name && u.Password == account.Password))
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

    public void RegisterAccount(User account)
    {
        if(VerifyAccount(account))
        {
            Console.WriteLine("Доступ к бд предоставлен");
        }
        else
        {
            if(_context.Users.Any(u => u.Name == account.Name))
            {
                Console.WriteLine("Введён неверный пароль");
            }   
            else
            {
                _context.Users.Add(account);
                _context.SaveChanges();
                Console.WriteLine("Доступ к бд предоставлен");
            } 
        }
    }

    public User GetAccountByName(string name)
    {
        return _context.Users.FirstOrDefault(u => u.Name == name);
    }

    public List<User> GetAllAccounts()
    {
        return _context.Users.ToList();
    }
}