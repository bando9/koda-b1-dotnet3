using Banking.Console.Interface;

public class TransferService : ITransferService
{
    
    
    public void ProccessTransfer(Account sender, Account received, int amount)
    {
        if (!sender.IsActive || !received.IsActive)
        {
            throw new ArgumentException("The recipient must have an active account.");   
        }
        else if (amount < 0)
        {
            throw new InvalidOperationException("you cannot transfer under 0");   
        }
        else if (amount > sender.Balance)
        {
            throw new InvalidOperationException("you dont have enough balance!");
        }
        else if(sender.Equals(received))
        {
            throw new ArgumentException("you cannot send to yourself!");
        }
        else
        {
            int newBalanceSender = sender.Balance - amount;
            int newBalanceReceived = received.Balance + amount;

            Console.WriteLine($"\nTransfer: Rp.{amount}");
            Console.WriteLine($"\n{sender.OwnerName}: Rp.{newBalanceSender}");
            Console.WriteLine($"{received.OwnerName}: Rp.{newBalanceReceived}");
            Console.WriteLine($"\ntransfer Rp.{amount} success!");
        }

         
    }
}