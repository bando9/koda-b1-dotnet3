Console.WriteLine("========================");
Console.WriteLine("KODA BANKING APP");
Console.WriteLine("========================");

Account andi = new CurrentAccount("ACC001", "Andi", 500_000,true);
Account budi = new SavingAccount("ACC002", "Budi", 300_000, true);

List<Account> accounts = new List<Account>()
{
    andi, budi
};

foreach(Account account in accounts){
    Console.WriteLine(account.GetInformation());
}

TransferService transferService = new TransferService();

transferService.ProccessTransfer(andi,budi,100_000);

Console.WriteLine("========================\n");
