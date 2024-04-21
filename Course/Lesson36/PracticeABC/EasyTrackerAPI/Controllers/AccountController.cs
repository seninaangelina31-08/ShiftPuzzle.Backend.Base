using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;   

public class AccountContrller : ControllerBase
{
    private readonly IAccountManager _accountManager;
    public AccountContrller(IAccountManager accountManager)
    {
        _accountManager = accountManager;
    }   

    [HttpPost("api/account/verify")]
    public bool Verify([FromBody] User user)
    {
        return _accountManager.VerifyAccount(user);
    }

    [HttpPost("/api/account/register")]
    public void Register([FromBody] User user)
    {
        _accountManager.RegisterAccount(user);
    }

    [HttpGet("/api/account/get/{name}")]
    public User Get(string name)
    {
        return _accountManager.GetAccount(name);
    }

    [HttpGet("/api/account/getall")]
    public IEnumerable<User> GetAll()
    {
        return _accountManager.GetAccounts();
    }
}