using Microsoft.AspNetCore.Identity;
public interface IAccountManager
{
    void RegisterAccount(IdentityUser account); 
    IdentityUser GetAccount(string accountName);
    List<IdentityUser> GetAccounts(); 
    bool VerifyAccount(IdentityUser account);
}