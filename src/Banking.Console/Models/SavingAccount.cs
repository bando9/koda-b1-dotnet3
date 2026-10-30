using Banking.Console.Models;


public class SavingAccount : Account
{
    // private Account account {get; private set;}
    public SavingAccount(string accountNumber, string ownerName, int balance, bool isActive) : base(accountNumber, ownerName, balance,isActive)
    {
        
    }

    public override String GetInformation()
    {
        return $"Saving - {base.GetInformation()}";
    }


}