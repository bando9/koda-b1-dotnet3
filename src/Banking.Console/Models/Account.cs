namespace Banking.Console.Models;

public abstract class Account
{
    // Property 
    public string AccountNumber { get; set; }
    public string OwnerName { get; set; }
    public int Balance { get; set; } 
    public bool IsActive { get; set; }

    public Account(string accountNumber, string ownerName, int balance, bool isActive)
    {
        if (String.IsNullOrWhiteSpace(accountNumber))
        {
            throw new ArgumentException("Account Number must be string");
        }
        if (String.IsNullOrWhiteSpace(ownerName))
        {
            throw new ArgumentException("Owner Name must be string");
        }
        if (balance <= 0)
        {
            throw new ArgumentException("Balance must be more than 0");
        }

        AccountNumber=accountNumber;
        OwnerName=ownerName;
        Balance=balance;
        IsActive=isActive;
    }


    public virtual String GetInformation()
    {
        return $"{AccountNumber} - {OwnerName} - Rp.{Balance} - {GetActiveAccount()}";
    }

    public String GetActiveAccount()
    {
        if (IsActive)
        {
            return "Active";
        } else
        {
            return "Frozen";
        }
    }


}