public interface IAccountManager
{
    void RegisterAccount(User account); 
    User GetAccountByName(string accountName);
    List<User> GetAllAccounts(); 
    bool VerifyAccount(User account);
}