using Microsoft.AspNetCore.Mvc;

[Controller]
[Route("/api/account/")]
public class AccountController : ControllerBase
{
    private readonly ITaskManager _taskManager;

    public AccountController(ITaskManager taskManager)
    {
        _taskManager = taskManager;
    }

    [HttpPost("verify")]
    public IActionResult VerifyAccount(string email, string password)
    {
        return Ok(_taskManager.VerifyAccount(email, password));
    }

    [HttpPost("register")]
    public IActionResult RegisterAccount([FromBody] User account)
    {
    
        bool isVerified = _taskManager.VerifyAccount(account);
        _taskManager
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
        return Ok(_taskManager.GetAccount(name));
    }

    [HttpGet("getall")]
    public IActionResult GetAccounts()
    {
        return Ok(_taskManager.GetAccounts());
    }
}