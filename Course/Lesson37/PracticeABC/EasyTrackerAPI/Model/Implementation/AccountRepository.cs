using System.Text.RegularExpressions;
public class AccountRepository : IAccountRepository
{
    private readonly AccountContext _accountContext;
    private event Action<User, string> _userActivity;

    public void LoggerFunc(User account, string action)
    {
        string logMessage = $"{account.Name};{account.Password};{DateTime.Now};{action}";
        using(StreamWriter writer = new StreamWriter("Logger.csv", true))
        {
            writer.WriteLine(logMessage);
        }
    }
    
    public AccountRepository(AccountContext accountContext)
    {
        _accountContext = accountContext;
        _userActivity += LoggerFunc;
    }


    public void RegisterAccount(User account)
    {
        Console.WriteLine($"[AccountRepository] registring account : {account.Email}");

        if (_accountContext.Users.Any(u => u.Email == account.Email))
        {
            Console.WriteLine($"Account {account.Email} exists");
            return;
        }
        

        if (Regex.IsMatch(account.Name, @"^[a-zA-Z]{5,50}\@[a-z]+\.(com|ru)"))
        {
            account.Email = account.Name;
            account.Name = account.Name.Split("@").First();
            Console.WriteLine($"Email {account.Email} is valid");
        }
        else
        {
            account.Email = account.Name;
        }

        account.ID = _accountContext.Users.Count() + 1;
        _accountContext.Users.Add(account);
        _userActivity?.Invoke(account, "registred new account");
        _accountContext.SaveChanges();
    }

    public User GetAccount(string accountName)
    {
        return _accountContext.Users.FirstOrDefault(u => u.Name == accountName);
    }

    public List<User> GetAccounts()
    {
        return _accountContext.Users.ToList();
    }

    public bool VerifyAccount(User account)
    {
        User user = _accountContext.Users.FirstOrDefault(u => u.Name == account.Name && u.Password == account.Password);
        if (user != null)
        {
            _userActivity.Invoke(user, "verified account");
            return true;
        }
        return false;
    }
}   