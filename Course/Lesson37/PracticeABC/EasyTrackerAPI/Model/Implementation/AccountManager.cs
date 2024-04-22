using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography.X509Certificates;

public class AccountManager : IAccountManager
{
    private readonly AccountContext _context;

    public static IdentityUser CurrentUser;    

    public AccountManager(AccountContext context)
    {
        _context = context;
    }

    public void RegisterAccount(IdentityUser account)
    {
        Console.WriteLine("[Account manager] registring account: " + account.UserName);

        if(_context.Users.Any(u => u.UserName == account.UserName))
        {
            IdentityUser u = _context.Users.FirstOrDefault(u => u.UserName == account.UserName);
            if (u.PasswordHash == account.PasswordHash)
            {
                Console.WriteLine("Account with name " + account.UserName + " already exists."); 
                return;
            }
        } 

        string[] domens = new string[2]{"ru", "com"};
        
        if (account.UserName.Contains("@") && account.UserName.Contains(".") && 
        (account.UserName.Length < 50) && 
        (account.UserName.Length > 5) &&
        domens.Any(d => account.UserName.Split(".").Last().Contains(d)))
        {
            account.Email = account.UserName;
            account.UserName = account.Email.Split("@").First();
            Console.WriteLine($"Account {account.UserName} is verifided sucesfully");
        }
        else 
        {
            account.Email = account.UserName;
            Console.WriteLine($"Account {account.UserName} is verifided sucesfully");
        }

        account.Id = Convert.ToString(_context.Users.Count() + 1);
        //IdentityUser us = new IdentityUser(account.Name);    
        _context.Users.Add(account); 
        _context.SaveChanges();
    }

    public IdentityUser GetAccount(string accountName) 
    {
       return _context.Users.FirstOrDefault(u => u.UserName == accountName);
    }

    public List<IdentityUser> GetAccounts()
    {
        return _context.Users.ToList(); 
    }

    public bool VerifyAccount(IdentityUser account)
    {
        if(_context.Users.Any(u => u.UserName == account.UserName && u.PasswordHash == account.PasswordHash))
        {
            CurrentUser = account;
            Console.WriteLine("Account verified."); 
            Logger(CurrentUser, "Account verified.");
            return true;    
        }
        else 
        {
            Console.WriteLine("Account not verified."); 
            return false; 
        }    
    }

    public static void Logger(IdentityUser account,string action)
    { 
        string logMessage = $"{account.UserName},{account.PasswordHash},{DateTime.Now},{action}\n"; 
        File.AppendAllText("ActionsLog.csv", logMessage);
    }
}   