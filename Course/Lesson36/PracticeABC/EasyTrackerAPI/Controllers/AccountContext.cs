using Microsoft.EntityFrameworkCore;


public class AccountContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public AccountContext(DbContextOptions<AccountContext> options)
        : base(options)
    {
    }
}