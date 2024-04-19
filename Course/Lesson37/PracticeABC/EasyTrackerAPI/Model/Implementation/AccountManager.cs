public class AccountManager : IAccountManager
{   
    private readonly IAccountRepository _accountRepository;
    public AccountManager(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
    }
    public void RegisterAccount(User account)
    {
        _accountRepository.RegisterAccount(account);
    } 
    public User GetAccount(string accountName)
    {
        return _accountRepository.GetAccount(accountName);
    }
    public List<User> GetAccounts()
    {
        return _accountRepository.GetAccounts();
    }
    public bool VerifyAccount(User account)
    {
        return _accountRepository.VerifyAccount(account);
    }
}