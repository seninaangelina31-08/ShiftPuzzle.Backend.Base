using Microsoft.AspNetCore.Mvc;


[Route("api/account")]
public class AccountController : ControllerBase
{
    private readonly IAccountManager _accountManager;

    public AccountController(IAccountManager accountManager)
    {
        _accountManager = accountManager;
    }

    [HttpPost("verify")]
    public bool VerifyAccount([FromBody] User user)
    {
        return _accountManager.VerifyAccount(user);
    }

    [HttpPost("register")]
    public void RegisterAccount([FromBody] User user)
    {
        _accountManager.RegisterAccount(user);
    }

    [HttpGet("get/{accountName}")]
    public User? GetAccount(string accountName)
    {
        return _accountManager.GetAccount(accountName);
    }

    [HttpGet("getall")]
    public List<User> GetAccounts()
    {
        return _accountManager.GetAccounts();
    }
}
