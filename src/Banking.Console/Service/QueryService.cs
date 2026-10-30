using Banking.Console.Models;

public class QueryService
{   
    private readonly IReadOnlyList<Account> _accounts;

    public QueryService(IReadOnlyList<Account> accounts)
    {
        _accounts=accounts;
    }

    public async Task<Account?> findAccount(string accountNumber)
    {
        await Task.Delay(300);
        return _accounts.FirstOrDefault(account => account.AccountNumber == accountNumber);
    }
}