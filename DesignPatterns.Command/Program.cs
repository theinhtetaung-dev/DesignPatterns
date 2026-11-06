using DesignPatterns.Command;
var account = new BankAccount(1000m);
var terminal = new TransactionTerminal();
terminal.Execute(new DepositCommand(account, 500m));
terminal.Execute(new WithdrawCommand(account, 200m));
terminal.UndoLast();
