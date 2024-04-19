using System.Text.RegularExpressions;
public class AccountRepository : IAccountRepository
{
    private readonly TaskTrackerContext _context;
    public AccountRepository(TaskTrackerContext context)
    {
        _context = context;
    }


    public void RegisterAccount(User account)
    {
        Console.WriteLine($"[AccountRepository] registring account : {account.Email}");

        if (_context.Users.Any(u => u.Email == account.Email))
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
        User user = _context.Users.FirstOrDefault(u => u.Name == account.Name && u.Password == account.Password);
        if (user != null)
        {
            return true;
        }
        return false;
    }
}   
