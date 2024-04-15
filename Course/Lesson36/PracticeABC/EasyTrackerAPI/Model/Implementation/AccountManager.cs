using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class AccountManager : IAccountManager
{
    private readonly AccountContext _context;

    public AccountManager(AccountContext context)
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

    public bool VerifyAccount(User account)
    {
        return _context.Users.Any(u => u.Name == account.Name && u.Password == account.Password);
    }
}