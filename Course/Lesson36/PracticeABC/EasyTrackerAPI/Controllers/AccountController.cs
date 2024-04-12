using Microsoft.AspNetCore.Mvc;
using System;

[ApiController]
public class AccountController : ControllerBase
{
    private readonly IAccountManager _accountManager;

    public AccountController(IAccountManager accountManager)
    {
        _accountManager = accountManager;
    }

    [HttpPost("api/account/verify")]
    public IActionResult VerifyAccount(User account)
    {
        var result = _accountManager.VerifyAccount(account);
        if (result)
        {
            return Ok("Account verified.");
        }
        else
        {
            return BadRequest("Account not verified.");
        }
    }

    [HttpPost("/api/account/register")]
    public IActionResult RegisterAccount(User account)
    {
        _accountManager.RegisterAccount(account);
        return Ok("Account registered successfully.");
    }

    [HttpGet("/api/account/get/{name}")]
    public IActionResult GetAccount(string name)
    {
        var account = _accountManager.GetAccount(name);
        if (account != null)
        {
            return Ok(account);
        }
        else
        {
            return NotFound($"Account with name {name} not found.");
        }
    }

    [HttpGet("/api/account/getall")]
    public IActionResult GetAllAccounts()
    {
        var accounts = _accountManager.GetAccounts();
        return Ok(accounts);
    }
}
