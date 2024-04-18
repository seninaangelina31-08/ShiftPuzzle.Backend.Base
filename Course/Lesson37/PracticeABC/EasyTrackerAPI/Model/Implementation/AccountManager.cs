

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
            Console.WriteLine("Account with name " + account.Name + " already exists."); 
            return;
        } 

        string [] domens = {"ru", "com", "com"};

        if ((account.Name.Contains("@")) && (account.Name.Contains(".")) && (account.Name.Length > 5) && (account.Name.Length < 50))
        {
            account.Email = account.Name;
            account.Name = account.Name.Substring(0, account.Name.IndexOf("@"));
            Console.WriteLine($"Email пользователя {account.Name} действителен.");
        }
        else
        {
            account.Email = account.Name;
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
        User user = _context.Users.FirstOrDefault(u => u.Name == account.Name 
        && u.Password == account.Password);

        if (user != null)
        {
            CurrentUser = user;
            Console.WriteLine("Account verified");
            Logger(user);
            user.IsVerified = true;
            return true;
        }
        else
        {
            Console.WriteLine("Account not verified");
            user.IsVerified = false;
            return false;
        }
    }

    private static void Logger(User account)
    {
        string logMessage = $"{account.Name}, {account.Password}, {DateTime.Now}\n";
        File.AppendAllText("ActionLog.csv", logMessage);
    }
}   