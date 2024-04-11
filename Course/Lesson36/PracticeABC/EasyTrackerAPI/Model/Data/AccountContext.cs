using Microsoft.EntityFrameworkCore;

public class AccountContext : DbContext
{ 
    public AccountContext(DbContextOptions<AccountContext> options) : base(options)
    {
    }

}