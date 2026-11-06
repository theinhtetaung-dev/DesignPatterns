using DesignPatterns.Observer;
var account = new BankAccount("ACC-1001", 1000m);
account.Subscribe(new SmsNotifier("09123456789"));
account.Subscribe(new EmailNotifier("customer@example.com"));
account.Deposit(500m);
account.Withdraw(200m);
