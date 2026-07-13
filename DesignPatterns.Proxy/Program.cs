using DesignPatterns.Proxy.BankAccount;

BankAccount bankAccount = new BankAccount("0912345678", "sasa@123", 1000m);

BankAccountProxy bankAccountProxy = new BankAccountProxy(bankAccount, "123456");

bankAccountProxy.Deposit(500m);
bankAccountProxy.Withdraw(200m);

decimal balance = bankAccount.GetBalance();
Console.WriteLine("Final balance: " + balance.ToString("N2") + " MMK");