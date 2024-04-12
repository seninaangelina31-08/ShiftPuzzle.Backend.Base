using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  

public class UserController : ControllerBase
{
    private IAccountManager _accountManager;
    
    public UserController(IAccountManager accountManager)
    {
        _accountManager = accountManager;
    }

    [HttpPost("api/account/verify")]
    public void Verify([FromBody] User user)
    {
        _accountManager.VerifyAccount(user);
    }

    [HttpPost("/api/account/register")] 
    public void Register([FromBody] User user)
    {
        _accountManager.RegisterAccount(user);
    }

    [HttpGet("/api/account/get/{name}")] 
    public User Get(string name)
    {
        return _accountManager.GetAccountByName(name);
    }

    [HttpGet("/api/account/getall")]
    public IEnumerable<User> GetAll()
    {
        return _accountManager.GetAllAccounts();
    }

}