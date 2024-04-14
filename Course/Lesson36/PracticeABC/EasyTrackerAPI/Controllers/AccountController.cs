using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;   

public class AccountController : ControllerBase
{
    private readonly IAccountManager _accountManager;

    public AccountController(IAccountManager accountManager)
    {
        _accountManager = accountManager;
    }

    [HttpPost("api/account/verify")] 
    public bool Verify(User account)
    {
        return _accountManager.VerifyAccount(account);
    }

    [HttpPost("/api/account/register")]
    public void Register(User account)
    {
        _accountManager.RegisterAccount(account);
    }

    [HttpGet("/api/account/get/{name}")]
    public User GetAcc(string accountName)
    {
        return _accountManager.GetAccount(accountName);
    }

    [HttpGet("/api/account/getall")]
    public List<User> GetAccs()
    {
        return _accountManager.GetAccounts();
    }
}