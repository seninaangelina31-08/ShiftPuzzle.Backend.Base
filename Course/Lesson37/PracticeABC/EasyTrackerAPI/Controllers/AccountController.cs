using Microsoft.AspNetCore.Mvc;

[Controller]
[Route("/api/account/")]
public class AccountController : ControllerBase
{
    private readonly IAccountManager _accountManager;

    public AccountController(IAccountManager accountManager)
    {
        _accountManager = accountManager;
    }

    [HttpPost("verify")]
    public IActionResult VerifyAccount([FromBody] User account)
    {
        bool isVerified = _accountManager.VerifyAccount(account);
        var response = new
        {
            User = account,
            IsVerified = isVerified
        };
        return Ok(response);
    }

    [HttpPost("register")]
    public IActionResult RegisterAccount([FromBody] User account)
    {
        _accountManager.RegisterAccount(account);
        bool isVerified = _accountManager.VerifyAccount(account);
        var response = new
        {
            User = account,
            IsVerified = isVerified
        };
        return Ok(response);
    }

    [HttpGet("get/{name}")]
    public IActionResult GetAccount(string name)
    {
        return Ok(_accountManager.GetAccount(name));
    }

    [HttpGet("getall")]
    public IActionResult GetAccounts()
    {
        return Ok(_accountManager.GetAccounts());
    }
}