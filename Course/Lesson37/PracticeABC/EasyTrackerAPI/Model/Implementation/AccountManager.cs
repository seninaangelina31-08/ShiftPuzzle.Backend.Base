

using System.Security.Cryptography.X509Certificates;

public class AccountManager : IAccountManager
{
    private readonly AccountContext _context;

    public  static User CurrentUser;    

    public AccountManager(AccountContext context)
    {
        _context = context;
    }

    public void RegisterAccount(User account)
    {
        Console.WriteLine("[Account manager] registring account: " + account.Name);

        if(_context.Users.Any(u => u.Name == account.Name))
        {
            User u = _context.Users.FirstOrDefault(u => u.Name == account.Name);
            if (u.Password == account.Password)
            {
                Console.WriteLine("Account with name " + account.Name + " already exists."); 
                return;
            }
        } 

        string[] domens = new string[2]{"ru", "com"};
        
        if (account.Name.Contains("@") && account.Name.Contains(".") && 
        (account.Name.Length < 50) && 
        (account.Name.Length > 5) &&
        domens.Any(d => account.Name.Split(".").Last().Contains(d)))
        {
            account.Email = account.Name;
            account.Name = account.Email.Split("@").First();
            Console.WriteLine($"Account {account.Name} is verifided sucesfully");
        }
        else 
        {
            account.Email = account.Name;
            Console.WriteLine($"Account {account.Name} is verifided sucesfully");
        }

        account.ID = _context.Users.Count() + 1;    
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

    public bool VerifyAccount(User account)
    {
        if(_context.Users.Any(u => u.Name == account.Name && u.Password == account.Password))
        {
            CurrentUser = account;
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