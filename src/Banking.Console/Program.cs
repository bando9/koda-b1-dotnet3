using Banking.Console.Models;

Console.WriteLine("========================");
Console.WriteLine("KODA BANKING APP");
Console.WriteLine("========================");

List<Account> accounts = new List<Account>()
{
    new CurrentAccount("ACC001", "Andi", 500_000,true),
    new SavingAccount("ACC002", "Budi", 300_000, true),
    new CurrentAccount("ACC003", "Cyntia", 100_000, false),
    new CurrentAccount("ACC004", "Dedi", 200_000, true)
};

System.Console.WriteLine("Type\tAccount\tOwner\tBalance\tStatus");
foreach(Account account in accounts){
    Console.WriteLine(account.GetInformation());
}


System.Console.WriteLine("\n\n============ Status Active ============");
var activeAccounts = accounts.Where(account => account.IsActive).ToList();

foreach(Account account in activeAccounts)
{
    System.Console.WriteLine(account.GetInformation());
}


System.Console.WriteLine("\n\n============ Urutan dari saldo terbesar ============");

var sortedActiveAccounts = activeAccounts.OrderByDescending(account => account.Balance);

foreach(Account account in sortedActiveAccounts)
{
    System.Console.WriteLine(account.GetInformation());
}

System.Console.WriteLine("\n\n============ Nama Seluruh Owner ============");
foreach(Account account in accounts)
{
    System.Console.WriteLine(account.OwnerName);
}


System.Console.WriteLine("\n\n============ Hitung Total Saldo ============");
var totalBalance = accounts.Sum(account => account.Balance);
System.Console.WriteLine($"Total Saldo: Rp.{totalBalance}");


System.Console.WriteLine("\n\n============ Cari Account ACC005 ============");
var queryService = new QueryService(accounts);

Task<Account?> account5 = queryService.findAccount("ACC005");

Account?[] result = await Task.WhenAll(account5);
foreach(Account? account in result)
{
    System.Console.WriteLine(account?.GetInformation() ?? "Account not registered!");
}










Console.WriteLine("========================\n");
