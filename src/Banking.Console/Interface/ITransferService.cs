namespace Banking.Console.Interface;

public interface ITransferService
{
    void ProccessTransfer(Account sender, Account received, int amount);
}