using DesignPatterns.Visitor;
IAccount[] accounts = [new SavingAccount(100000m), new BusinessAccount(500000m)];
var feeVisitor = new MonthlyFeeVisitor();
foreach (var account in accounts) account.Accept(feeVisitor);
