using Banking.Console.Models;

public class CurrentAccount : Account
{
    public CurrentAccount(string accountNumber, string ownerName, int balance, bool isActive) : base(accountNumber, ownerName, balance, isActive)
    {
        
    }

    public override String GetInformation()
    {
        return $"Current - {base.GetInformation()}";
    }


}